using kursovaya;
using System.Collections.Generic;
using System.Linq;
using kursovaya.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models = kursovaya.Models;

namespace kursovaya.Services
{
    public class DatabaseService
    {
        public List<kursovaya.Models.Table> GetTables()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Tables.ToList(); // Получение всех записей из таблицы Table
            }
        }
        public void AddVivod(string resultText, int tableId)
        {
            using (var context = new ApplicationDbContext())
            {
                // Проверяем, существует ли запись в таблице Table
                var table = context.Tables.Find(tableId);
                if (table == null)
                {
                    throw new Exception($"Table с ID {tableId} не найдена.");
                }

                // Проверяем, существует ли уже Vivod для указанного TableId
                var vivod = context.Vivods.FirstOrDefault(v => v.TableId == tableId);
                if (vivod == null)
                {

                    // Создаем новую запись
                    vivod = new Vivod()
                    {
                        result = resultText,
                        TableId = tableId,
                        Table = table
                    };
                    context.Vivods.Add(vivod);
                }
                else
                {
                    vivod.result = resultText;
                    vivod.TableId = tableId;
                    vivod.Table = table;
                }
                 context.SaveChanges();
                
                
            }
        }
    }
}
