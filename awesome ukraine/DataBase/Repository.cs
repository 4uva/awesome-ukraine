using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace awesome_ukraine.DataBase
{
    public class Repository
    {
        public sealed class CsvDataClassMap : ClassMap<Item>
        {
            public CsvDataClassMap()
            {
                AutoMap(new Configuration() { MemberTypes = MemberTypes.Fields });
                Map(m => m.FieldOfActivity).Name("Field of activity");
            }
        }

        List<Item> Database;/*field name*/
       
        public Repository (string path)
        {
            using (TextReader textReader = File.OpenText(path))
            {
                using (var csv = new CsvReader(textReader))
                {
                    csv.Configuration.RegisterClassMap<CsvDataClassMap>();
                    var records = csv.GetRecords<Item>();
                    Database = records.ToList();
                }
            }
        }
    } 
}


