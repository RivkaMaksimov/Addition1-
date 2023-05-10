using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Repositories.Models;

namespace Repositories
{
    class Corona_diseaseRepository : ICorona_diseaseRepository
    {

        HMO_corona_database context;
        public Corona_diseaseRepository(HMO_corona_database context)
        {
            this.context = context;
        }
        public void Create(TblCoronaDisease objToCreate)               //הוספת קטגוריה
        {
            context.TblCoronaDisease.Add(objToCreate);
            context.SaveChanges();
        }

        public void Delete(int id)                                  //הסרת קטגוריה
        {
            context.TblCoronaDisease.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<TblCoronaDisease> GetAll()                         //שליפת רשימת הקטגוריות
        {
            return context.TblCoronaDisease.ToList();
        }

        public TblCoronaDisease GetById(int id)                        // שליפת קטגוריה לפי קוד 
        {
            return context.TblCoronaDisease.First(c => c.DiseaseId == id); //single
        }

        public void Update(TblCoronaDisease objToUpdate)                //עידכון קטגוריה ברשימה
        {
            context.TblCoronaDisease.Update(objToUpdate);
            context.SaveChanges();
            //לתפוס את השגיאה של קטגוריה לא קימת
        }
    }
}
