using Newtonsoft.Json;
using StacjaPaliwLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.DataAccess
{
    public class ProductDataAccess : IDataAccess<Product>
    {
        private string _table_file_path;

        private List<Product> m_products;

        public ProductDataAccess()
        {
            _table_file_path = @"db\Product.json";
            if (!File.Exists(_table_file_path))
            { 
                m_products = new List<Product>(); 
                return;
            }

            string json_table_string = File.ReadAllText(_table_file_path);
            m_products = JsonConvert.DeserializeObject<List<Product>>(json_table_string);
        }
        public List<Product> GetAllRows()
        {
            return m_products;
        }
        public Product ReadRow(int id)
        {
            foreach (Product product in m_products)
            {
                if (product.m_id == id) return product;
            }

            Product dummy_error_obj = new Product();
            dummy_error_obj.m_id = 0;
            return dummy_error_obj;
        }


        public void AddRow(Product row)
        {
            m_products.Add(row);
        }
        public void DeleteRow(Product row)
        {
            // TODO: zabezpieczenia przed wyrzutkami po usunięciu wiersza
            m_products.Remove(row);
        }
        public void SaveToJsonFile()
        {
            string directory_to_check = _table_file_path.Split(@"\")[0];
            if(!Directory.Exists(directory_to_check))
            {
                Directory.CreateDirectory(directory_to_check);
            }

            string json_to_save = JsonConvert.SerializeObject(m_products, Formatting.Indented);
            if (File.Exists(_table_file_path))
            {
                File.WriteAllText(_table_file_path, json_to_save);
            }
            else
            {
                using (FileStream fs = File.Create(_table_file_path))
                {
                    byte[] data = new UTF8Encoding(true).GetBytes(json_to_save);
                    fs.Write(data, 0, data.Length);
                }
            }
        }

    }
}
