using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XF.LocalDB.Model;

namespace XF.LocalDB.MercadoriaViewModels
{
    public class MercadoriaViewModel
    {
        public MercadoriaViewModel() { }
        #region Propriedades
        public string NomeDaMercadoria { get; set; }

        public string PesoDaMercadoria { get; set; }
        public string NomeDoProduto { get; set; }
        public string EmailDoProdutor { get; set; }
        public string NCM { get; set; }
        public List<Mercadoria> Mercadorias
        {
            get
            {
                return
                App.MercadoriaModel.GetMercadorias().ToList();
            }
        }
        #endregion
    }
}
