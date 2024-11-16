using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.DataAccess
{
    public class DataAccess<T> : IDataAccess<T> where T : class, new()
    {
        private string _tableFilePath;
        public static int _availableId { get; private set; }
        private List<T> rows { get; set; }

        public DataAccess()
        {
            string entityName = typeof(T).Name;
            string directory = "db";
            _tableFilePath = $@"{directory}\{entityName}.json";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(_tableFilePath))
            {
                rows = new List<T>();
                _availableId = 1;
                File.Create(_tableFilePath);
                return;
            }

            string jsonTableString = File.ReadAllText(_tableFilePath);
            rows = JsonConvert.DeserializeObject<List<T>>(jsonTableString) ?? new List<T>(); // if json des fails, then new list

            // Update _availableId
            if (rows.Count > 0 && typeof(T).GetProperty("id") != null)
            {
                _availableId = rows
                               .Select(row => (int)typeof(T).GetProperty("id").GetValue(row))
                               .Max() + 1;
            }
            else
            {
                _availableId = 1;
            }
        }
        public List<T> GetAllRows()
        {
            return rows;
        }
        public T ReadRow(int id)
        {
            var idProperty = typeof(T).GetProperty("id");
            if (idProperty == null)
            {
                throw new InvalidOperationException("Type T does not have an 'id' property.");
            }

            foreach (var row in rows)
            {
                if ((int)idProperty.GetValue(row) == id)
                {
                    return row;
                }
            }

            return new T(); // Return a new default object if not found
        }
        public void AddRow(T row)
        {
            var idProperty = typeof(T).GetProperty("id");
            if (idProperty == null)
            {
                throw new InvalidOperationException("Type T does not have an 'id' property.");
            }

            idProperty.SetValue(row, _availableId);
            rows.Add(row);
            _availableId++;
        }
        public void DeleteRow(int id)
        {
            var idProperty = typeof(T).GetProperty("id");
            if (idProperty == null)
            {
                throw new InvalidOperationException("Type T does not have an 'id' property.");
            }

            rows.RemoveAll(row => (int)idProperty.GetValue(row) == id);

            if (rows.Count > 0)
            {
                _availableId = rows
                               .Select(row => (int)idProperty.GetValue(row))
                               .Max() + 1;
            }
            else
            {
                _availableId = 1;
            }
        }
        public void Save()
        {
            string jsonToSave = JsonConvert.SerializeObject(rows, Formatting.Indented);

            if (File.Exists(_tableFilePath))
            {
                File.WriteAllText(_tableFilePath, jsonToSave);
            }
            else
            {
                using (FileStream fs = File.Create(_tableFilePath))
                {
                    byte[] data = new UTF8Encoding(true).GetBytes(jsonToSave);
                    fs.Write(data, 0, data.Length);
                }
            }
        }
    }

}
