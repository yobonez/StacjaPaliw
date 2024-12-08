using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using StacjaPaliwLogic.Models;
using Newtonsoft.Json.Linq;

namespace StacjaPaliwLogic.DataAccess
{
    public class DataAccess<T> : IDataAccess<T> where T : class, new()
    {
        private string _tableFilePath;
        public static int _availableId { get; private set; }
        private List<T> rows { get; set; }
        private Type? optionalType { get; set; }

        public DataAccess(Type optionalObjType = null)
        {
            string entityName = typeof(T).Name;
            if(entityName == "Object")
            {
                entityName = optionalObjType.Name;
                optionalType = optionalObjType;
            }

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
                //File.Create(_tableFilePath);
                return;
            }

            string jsonTableString = File.ReadAllText(_tableFilePath);
            rows = JsonConvert.DeserializeObject<List<T>>(jsonTableString) ?? new List<T>(); // if json des fails, then new list

            // Update _availableId
            if (rows.Count > 0 && (typeof(T).GetProperty("id") != null ||
                                   optionalObjType.GetProperty("id") != null))
            {
                if (optionalType != null)
                {
                    // trzeba drutnąć niestety
                    var lastRow = rows[rows.Count - 1];

                    var idProp = lastRow.GetType().GetProperty("First").GetValue(lastRow);
                    var propValue = idProp.GetType().GetProperty("Value").GetValue(idProp);
                    var propValueValue = propValue.GetType().GetProperty("Value").GetValue(propValue);

                    _availableId = Convert.ToInt32(propValueValue) + 1;
                    //System.Reflection.TargetException
                    //_availableId = rows
                    //               .Select(row => (int)optionalType.GetProperty("id").GetValue(row))
                    //               .Max() + 1;
                }
                else
                {
                    _availableId = rows
                                   .Select(row => (int)typeof(T).GetProperty("id").GetValue(row))
                                   .Max() + 1;
                }
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
            if (optionalType != null)
            {
                idProperty = optionalType.GetProperty("id");
            }

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
            if (optionalType != null)
            {
                idProperty = optionalType.GetProperty("id");
            }

            if (idProperty == null)
            {
                throw new InvalidOperationException("Type T does not have an 'id' property.");
            }

            idProperty?.SetValue(row, _availableId);
            rows.Add(row);
            _availableId++;
        }
        public void AddRows(List<T> rows)
        {
            foreach (var row in rows)
            {
                AddRow(row);
            }
        }
        public void DeleteRow(int id)
        {
            var idProperty = typeof(T).GetProperty("id");
            if (optionalType != null)
            {
                idProperty = optionalType.GetProperty("id");
            }

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
                //File.AppendAllText
                //using (FileStream fs = File.Create(_tableFilePath))
                //{
                //    byte[] data = new UTF8Encoding(true).GetBytes(jsonToSave);
                //    fs.Write(data, 0, data.Length);
                //}
                File.AppendAllText(_tableFilePath, jsonToSave);
            }
        }
    }

}
