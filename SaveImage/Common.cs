using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveImage
{
    static class Common
    {
        static public string connectionString = Properties.Settings.Default.Images_dbConnectionString;
        static public string cameraName = Properties.Settings.Default.Camera_Name;
        static public string dbName = Properties.Settings.Default.db_Name;

        static public string path = Path.GetTempPath();

        public const int VK_SHIFT = 0x10;
        public const int VK_A = 0x41;

        static public string entityConnectionString = CreateEntityConnectionString();

        private static string CreateEntityConnectionString()
        {
            // Specify the provider name, server and database.
            string providerName = "System.Data.SqlClient";
            string providerString = Properties.Settings.Default.Images_dbConnectionString;

            // Initialize the EntityConnectionStringBuilder.
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();

            //Set the provider name.
            entityBuilder.Provider = providerName;

            // Set the provider-specific connection string.
            entityBuilder.ProviderConnectionString = providerString;

            // Set the Metadata location.
            entityBuilder.Metadata = @"res://*/ModelDB.csdl|
                                    res://*/ModelDB.ssdl|
                                    res://*/ModelDB.msl";

            return entityBuilder.ToString();
        }

        public static IOrderedQueryable<T> Order<T>(this IQueryable<T> source, string propertyName, System.Windows.Forms.SortOrder descending, bool anotherLevel = false)
        {
            var param = Expression.Parameter(typeof(T), string.Empty);
            var property = Expression.PropertyOrField(param, propertyName);
            var sort = Expression.Lambda(property, param);

            var call = Expression.Call(
                typeof(Queryable),
                (!anotherLevel ? "OrderBy" : "ThenBy") +
                (descending == System.Windows.Forms.SortOrder.Descending ? "Descending" : string.Empty),
                new[] { typeof(T), property.Type },
                source.Expression,
                Expression.Quote(sort));

            return (IOrderedQueryable<T>)source.Provider.CreateQuery<T>(call);
        }

        public static void ShowErrorMessage(string text)
        {
            MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowInfoMessage(string text)
        {
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}

//Проверка валидации EF
//catch (DbEntityValidationException ex)
//{
//    foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
//    {
//        Common.ShowErrorMessage("Object: " + validationError.Entry.Entity.ToString());
//        foreach (DbValidationError err in validationError.ValidationErrors)
//        {
//            Common.ShowErrorMessage(err.ErrorMessage + "");
//        }
//    }
//}