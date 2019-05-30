using PetShopProject.DAL;
using PetShopProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject.Business
{
   public class ListofProBusiness
    {
        private ListofProinInvoiceRepository listofProinInvoiceRepository;
        public ListofProBusiness()
        {
            listofProinInvoiceRepository = new ListofProinInvoiceRepository();
        }
        public DataSet getList(int invoiceId)
        {
            return listofProinInvoiceRepository.getListInvoice(invoiceId);
        }
        public bool Add(ChiTietHoaDon chiTietHoaDon, ref string err)
        {
            return listofProinInvoiceRepository.Add(chiTietHoaDon, ref err);
        }
        public bool Edit(ChiTietHoaDon chiTietHoaDon, ref string err)
        {
            return listofProinInvoiceRepository.Edit(chiTietHoaDon, ref err);
        }
        public bool Delete(int InvoiceID, int proId, ref string err)
        {
            return listofProinInvoiceRepository.Delete(InvoiceID,proId, ref err);
        }
        
    }
}
