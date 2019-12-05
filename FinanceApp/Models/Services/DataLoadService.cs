using TinyCsvParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Maps.CSVMaps;
using TinyCsvParser.Mapping;
using FinanceApp.Models.DTOS;
using System.Text;

namespace FinanceApp.Models.Services
{
    /// <summary>
    /// In the future, this would ideally be able to load the data automatically through a scraper/API
    /// But for now use CSVs
    /// </summary>
    public class DataLoadService
    {
        public DataLoadService(string rootPath)
        {
            var dataFiles = GetFileNames(rootPath);
            if (dataFiles.Any()){
                var files = new List<TDTransactionDTO>();
                foreach(var file in dataFiles)
                {
                    files.AddRange(ReadTransactions<TDCSVMap,TDTransactionDTO>(file));
                }
            }
        }

        private ICollection<string> GetFileNames(string rootPath)
        {
            var dataLocation = Path.Join(rootPath, "Data", "TransactionData");
            var files = Directory.GetFiles(dataLocation, "*.csv");
            return files;
        }

        private IEnumerable<S> ReadTransactions<T, S>(string fileName) where T : ICsvMapping<S>, new()
        {
            CsvParserOptions options = new CsvParserOptions(false, ',');
            var map = new T();
            var parser = new CsvParser<S>(options, map);
            var transactions = parser.ReadFromFile(fileName, Encoding.ASCII).ToList();
            return transactions.Select(s => s.Result);
        }
    }
}
