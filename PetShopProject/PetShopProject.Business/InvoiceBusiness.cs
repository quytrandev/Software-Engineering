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
    public class InvoiceBusiness
    {
        private InvoiceRepository invoiceRepository;
        public InvoiceBusiness()
        {
            invoiceRepository = new InvoiceRepository();
        }
        public DataSet getList()
        {
            return invoiceRepository.getList();
        }
        public bool Add(HoaDon hoaDon, ref string err)
        {
            return invoiceRepository.Add(hoaDon,ref err);
        }
        public bool Edit(HoaDon hoaDon, ref string err)
        {
            return invoiceRepository.Edit(hoaDon, ref err);
        }
        public bool Delete(int InvoiceID, ref string err)
        {
            return invoiceRepository.Delete(InvoiceID, ref err);
        }
        public DataSet search(int InvoiceID)
        {
            return invoiceRepository.search(InvoiceID);
        }
        public DataSet getLastId()
        {
            return invoiceRepository.getLastId();
        }
    }
}
