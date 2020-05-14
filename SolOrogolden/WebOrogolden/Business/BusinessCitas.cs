using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using WebOrogolden.Models;

namespace WebOrogolden.Business
{
    public class BusinessCitas
    {
        public void AddCita(Citas citas)
        {
            using (Database1Entities db = new Database1Entities())
            {
                Citas emai = db.Citas.Where(x => x.Email == citas.Email).FirstOrDefault();
                if (emai == null)
                {
                    db.Citas.Add(citas);
                    db.SaveChanges();
                }
                else
                {
                    throw new ApplicationException("Usted ya tiene una cita reservada");
                }
            }
        }
    }
}