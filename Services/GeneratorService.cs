using System.Text;

namespace WwwSqlObject.Services
{
    public class GeneratorService
    {
        public string GetData(string data)
        {
            var sb = new StringBuilder();
            var splittedInitialData = data.Split(new string[] { "\n" }, StringSplitOptions.None);



            return sb.ToString();
        }

        private string GetDotNetType(string dbColumnType)
        {
            string returnType = string.Empty;
            if (dbColumnType.Equals("nvarchar"))
                returnType = "string";
            else if (dbColumnType.Equals("varchar"))
                returnType = "string";
            else if (dbColumnType.Equals("int"))
                returnType = "int";
            else if (dbColumnType.Equals("bit"))
                returnType = "bool";
            else if (dbColumnType.Equals("bigint"))
                returnType = "long";
            else if (dbColumnType.Equals("binary"))
                returnType = "byte[]";
            else if (dbColumnType.Equals("char"))
                returnType = "string";
            else if (dbColumnType.Equals("date"))
                returnType = "DateTime";
            else if (dbColumnType.Equals("datetime"))
                returnType = "DateTime";
            else if (dbColumnType.Equals("datetime2"))
                returnType = "DateTime";
            else if (dbColumnType.Equals("datetimeoffset"))
                returnType = "DateTimeOffset";
            else if (dbColumnType.Equals("decimal"))
                returnType = "decimal";
            else if (dbColumnType.Equals("float"))
                returnType = "float";
            else if (dbColumnType.Equals("image"))
                returnType = "byte[]";
            else if (dbColumnType.Equals("money"))
                returnType = "decimal";
            else if (dbColumnType.Equals("nchar"))
                returnType = "char";
            else if (dbColumnType.Equals("ntext"))
                returnType = "string";
            else if (dbColumnType.Equals("numeric"))
                returnType = "decimal";
            else if (dbColumnType.Equals("nvarchar"))
                returnType = "string";
            else if (dbColumnType.Equals("real"))
                returnType = "double";
            else if (dbColumnType.Equals("smalldatetime"))
                returnType = "DateTime";
            else if (dbColumnType.Equals("smallint"))
                returnType = "short";
            else if (dbColumnType.Equals("smallmoney"))
                returnType = "decimal";
            else if (dbColumnType.Equals("text"))
                returnType = "string";
            else if (dbColumnType.Equals("time"))
                returnType = "TimeSpan";
            else if (dbColumnType.Equals("timestamp"))
                returnType = "DateTime";
            else if (dbColumnType.Equals("tinyint"))
                returnType = "byte";
            else if (dbColumnType.Equals("uniqueidentifier"))
                returnType = "Guid";
            else if (dbColumnType.Equals("varbinary"))
                returnType = "byte[]";

            return returnType;
        }
    }
}
