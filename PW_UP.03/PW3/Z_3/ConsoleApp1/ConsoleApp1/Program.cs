using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Z_3
{
    class Program
    {
        class SQLCommand
        {
            private string commandtext;
            public string CommandText
            {
                get
                {
                    return commandtext;
                }
                private set
                {
                    commandtext = UpperOperators(value);
                }
            }
            private string UpperOperators(string commandText)
            {
                string[] operators = { "create", "alter", "drop", "select", "insert", "update", "delete", "table", "grant", "revoke", "from", "where", 
                    "and", "or", "not", "in", "between", "like", "order by", "asc", "desc", "group by", "having", "use", "not null", "default", "unique", 
                    "primary key", "foreign key", "check", "index", "join", "on", "truncate", "add", "modify", "values", "set", "exists", "commit", "rollback", 
                    "all", "any", "is null", "as", "database", "avg", "sum", "min", "max", "count", "union" };
                for (int i = 0; i < operators.Length; i++)
                {
                    commandText = commandText.Replace(operators[i], operators[i].ToUpper());
                }
                return commandText;
            }
            public SQLCommand(string commandText)
            {
                CommandText = commandText;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
