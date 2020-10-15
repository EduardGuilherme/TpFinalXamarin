using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XF.LocalDB.Data;

namespace XF.LocalDB.Model
{
    public class Mercadoria
    {
        public Mercadoria()
        {
            database =
            DependencyService.Get<ISQLite>().GetConexao();
            database.CreateTable<Mercadoria>();
        }
        #region Propriedades
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NomeDaMercadoria { get; set; }

        public string PesoDaMercadoria { get; set; }
        public string NomeDoProduto { get; set; }
        public string EmailDoProdutor { get; set; }
        public string NCM { get; set; }
        #endregion
        #region Aluno Local Database
        private SQLiteConnection database;
        static object locker = new object();
        public int SalvarMercadoria(Mercadoria aluno)
        {
            lock (locker)
            {
                if (aluno.Id != 0)
                {
                    database.Update(aluno);
                    return aluno.Id;
                }
                else return database.Insert(aluno);
            }
        }
        public IEnumerable<Mercadoria> GetMercadorias()
        {
            lock (locker)
            {
                return (from c in database.Table<Mercadoria>()
                        select c).ToList();
            }
        }
        public Mercadoria GetMercadoria(int Id)
        {
            lock (locker)
            {
                // return database.Query< Aluno>("SELECT * FROM[Aluno] WHERE[Id] = " + Id);
            return database.Table<Mercadoria>().Where(c => c.Id ==
            Id).FirstOrDefault();
            }
        }
        public int RemoverMercadoria(int Id)
        {
            lock (locker)
            {
                return database.Delete<Mercadoria>(Id);
            }
        }
        #endregion
    }
}
