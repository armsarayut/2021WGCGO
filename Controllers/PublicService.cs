using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoWMS.Server.Data;
using GoWMS.Server.Models;
using GoWMS.Server.Models.Public;


namespace GoWMS.Server.Controllers
{
    public class PublicService
    {
        readonly PublicDAL objDAL = new PublicDAL();

        #region"MENU6.1"
        public List<Class6_1> GetAllMenu6_1()
        {
            List<Class6_1> retlist = objDAL.GetAllMenu6_1().ToList();
            return retlist;
        }

        public List<Class6_1> GetMenu6_1bydate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_1> retlist = GetMenu6_1bydate( dtStart,  dtStop).ToList();
            return retlist;
        }

        public List<Class6_1> GetMenu6_1bydatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_1> retlist = GetMenu6_1bydatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }

        #endregion

        #region""MENU6.2A"
        public List<Class6_2_A> GetAllMenu6_2A()
        {
            List<Class6_2_A> retlist = objDAL.GetAllMenu6_2A().ToList();
            return retlist;
        }

        public List<Class6_2_A> GetMenu6_2AbyDate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_2_A> retlist = objDAL.GetMenu6_2AbyDate( dtStart,  dtStop).ToList();
            return retlist;
        }

        public List<Class6_2_A> GetMenu6_2AbyDatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_2_A> retlist = objDAL.GetMenu6_2AbyDatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }

        #endregion

        #region"MENU6.2B"
        public List<Class6_2_B> GetAllMenu6_2B()
        {
            List<Class6_2_B> retlist = objDAL.GetAllMenu6_2B().ToList();
            return retlist;
        }

        public List<Class6_2_B> GetMenu6_2Bbydate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_2_B> retlist = objDAL.GetAllMenu6_2BbyDate(dtStart, dtStop).ToList();
            return retlist;
        }

        public List<Class6_2_B> GetMenu6_2Bbydatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_2_B> retlist = objDAL.GetAllMenu6_2BbyDatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.3A"
        public List<Class6_3_A> GetAllMenu6_3A()
        {
            List<Class6_3_A> retlist = objDAL.GetAllMenu6_3A().ToList();
            return retlist;
        }

        public List<Class6_3_A> GetAllMenu6_3Abylimit(long limitrec, long currentPage)
        {
            List<Class6_3_A> retlist = objDAL.GetAllMenu6_3Abylimit(limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.3B"
        public List<Class6_3_B> GetAllMenu6_3B()
        {
            List<Class6_3_B> retlist = objDAL.GetAllMenu6_3B().ToList();
            return retlist;
        }

        public List<Class6_3_B> GetAllMenu6_3Bbylimit(long limitrec, long currentPage)
        {
            List<Class6_3_B> retlist = objDAL.GetAllMenu6_3Bbylimit(limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.3C"
        public List<Class6_3_C> GetAllMenu6_3CbyDetail()
        {
            List<Class6_3_C> retlist = objDAL.GetAllMenu6_3CbyDetail().ToList();
            return retlist;
        }

        public List<Class6_3_C> GetAllMenu6_3CbyDetaillimit(long limitrec, long currentPage)
        {
            List<Class6_3_C> retlist = objDAL.GetAllMenu6_3CbyDetaillimit(limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.3D"
        public List<Class6_3_D> GetAllMenu6_3DbyDetail()
        {
            List<Class6_3_D> retlist = objDAL.GetAllMenu6_3DbyDetail().ToList();
            return retlist;
        }

        public List<Class6_3_D> GetAllMenu6_3DbyDetaillimit(long limitrec, long currentPage)
        {
            List<Class6_3_D> retlist = objDAL.GetAllMenu6_3DbyDetaillimit(limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.3E"
        public List<Class6_3_E> GetAllMenu6_3EbyDetail()
        {
            List<Class6_3_E> retlist = objDAL.GetAllMenu6_3EbyDetail().ToList();
            return retlist;
        }

        public List<Class6_3_E> GetAllMenu6_3EbyDetaillimit(long limitrec, long currentPage)
        {
            List<Class6_3_E> retlist = objDAL.GetAllMenu6_3EbyDetaillimit(limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.4A"
        public List<Class6_4_A> GetAllMenu6_4A()
        {
            List<Class6_4_A> retlist = objDAL.GetAllMenu6_4A().ToList();
            return retlist;
        }

        public List<Class6_4_A> GetMenu6_4Abydate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_4_A> retlist = objDAL.GetAllMenu6_4AbyDate(dtStart, dtStop).ToList();
            return retlist;
        }

        public List<Class6_4_A> GetMenu6_4Abydatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_4_A> retlist = objDAL.GetAllMenu6_4AbyDatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.4B"
        public List<Class6_4_B> GetAllMenu6_4B()
        {
            List<Class6_4_B> retlist = objDAL.GetAllMenu6_4B().ToList();
            return retlist;
        }

        public List<Class6_4_B> GetMenu6_4Bbydate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_4_B> retlist = objDAL.GetAllMenu6_4BbyDate(dtStart, dtStop).ToList();
            return retlist;
        }

        public List<Class6_4_B> GetMenu6_4Bbydatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_4_B> retlist = objDAL.GetAllMenu6_4BbyDatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion
        #region"MENU6.4C"
        public List<Class6_4_C> GetAllMenu6_4C()
        {
            List<Class6_4_C> retlist = objDAL.GetAllMenu6_4C().ToList();
            return retlist;
        }

        public List<Class6_4_C> GetMenu6_4Cbydate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_4_C> retlist = objDAL.GetAllMenu6_4CbyDate(dtStart, dtStop).ToList();
            return retlist;
        }

        public List<Class6_4_C> GetMenu6_4Cbydatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_4_C> retlist = objDAL.GetAllMenu6_4CbyDatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.4D"
        public List<Class6_4_D> GetAllMenu6_4D()
        {
            List<Class6_4_D> retlist = objDAL.GetAllMenu6_4D().ToList();
            return retlist;
        }

        public List<Class6_4_D> GetMenu6_4Dbydate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_4_D> retlist = objDAL.GetAllMenu6_4DbyDate(dtStart, dtStop).ToList();
            return retlist;
        }

        public List<Class6_4_D> GetMenu6_4Dbydatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_4_D> retlist = objDAL.GetAllMenu6_4DbyDatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion
        #region"MENU6.5A"
        public List<Class6_5_A> GetAllMenu6_5A()
        {
            List<Class6_5_A> retlist = objDAL.GetAllMenu6_5A().ToList();
            return retlist;
        }

        public List<Class6_5_A> GetMenu6_5Abydate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_5_A> retlist = objDAL.GetAllMenu6_5AbyDate(dtStart, dtStop).ToList();
            return retlist;
        }

        public List<Class6_5_A> GetMenu6_5Abydatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_5_A> retlist = objDAL.GetAllMenu6_5AbyDatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.5B"
        public List<Class6_5_B> GetAllMenu6_5B()
        {
            List<Class6_5_B> retlist = objDAL.GetAllMenu6_5B().ToList();
            return retlist;
        }

        public List<Class6_5_B> GetMenu6_5Bbydate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_5_B> retlist = objDAL.GetAllMenu6_5BbyDate(dtStart, dtStop).ToList();
            return retlist;
        }

        public List<Class6_5_B> GetMenu6_5Bbydatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_5_B> retlist = objDAL.GetAllMenu6_5BbyDatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.6"
        public List<Class6_6> GetAllMenu6_6BbyDate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_6> retlist = objDAL.GetAllMenu6_6BbyDate(dtStart, dtStop).ToList();
            return retlist;
        }

        public IEnumerable<Class6_6> GetAllMenu6_6BbyDateitem(DateTime dtStart, DateTime dtStop, string item)
        {
            List<Class6_6> retlist = objDAL.GetAllMenu6_6BbyDateitem(dtStart, dtStop, item).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.7A"
        public List<Class6_7_A> GetAllMenu6_7A()
        {
            List<Class6_7_A> retlist = objDAL.GetAllMenu6_7A().ToList();
            return retlist;
        }

        public List<Class6_7_A> GetMenu6_7Abydate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_7_A> retlist = objDAL.GetAllMenu6_7AbyDate(dtStart, dtStop).ToList();
            return retlist;
        }

        public List<Class6_7_A> GetMenu6_7Abydatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_7_A> retlist = objDAL.GetAllMenu6_7AbyDatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.7B"
        public List<Class6_7_B> GetAllMenu6_7B()
        {
            List<Class6_7_B> retlist = objDAL.GetAllMenu6_7B().ToList();
            return retlist;
        }

        public List<Class6_7_B> GetMenu6_7Bbydate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_7_B> retlist = objDAL.GetAllMenu6_7BbyDate(dtStart, dtStop).ToList();
            return retlist;
        }

        public List<Class6_7_B> GetMenu6_7Bbydatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_7_B> retlist = objDAL.GetAllMenu6_7BbyDatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.7C"
        public List<Class6_7_C> GetAllMenu6_7C()
        {
            List<Class6_7_C> retlist = objDAL.GetAllMenu6_7C().ToList();
            return retlist;
        }

        public List<Class6_7_C> GetMenu6_7Cbydate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_7_C> retlist = objDAL.GetAllMenu6_7CbyDate(dtStart, dtStop).ToList();
            return retlist;
        }

        public List<Class6_7_C> GetMenu6_7Cbydatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_7_C> retlist = objDAL.GetAllMenu6_7CbyDatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.7D"
        public List<Class6_7_D> GetAllMenu6_7D()
        {
            List<Class6_7_D> retlist = objDAL.GetAllMenu6_7D().ToList();
            return retlist;
        }

        public List<Class6_7_D> GetMenu6_7Dbydate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_7_D> retlist = objDAL.GetAllMenu6_7DbyDate(dtStart, dtStop).ToList();
            return retlist;
        }

        public List<Class6_7_D> GetMenu6_7Dbydatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_7_D> retlist = objDAL.GetAllMenu6_7DbyDatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.7E"
        public List<Class6_7_E> GetAllMenu6_7E()
        {
            List<Class6_7_E> retlist = objDAL.GetAllMenu6_7E().ToList();
            return retlist;
        }

        public List<Class6_7_E> GetMenu6_7Ebydate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_7_E> retlist = objDAL.GetAllMenu6_7EbyDate(dtStart, dtStop).ToList();
            return retlist;
        }

        public List<Class6_7_E> GetMenu6_7Ebydatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_7_E> retlist = objDAL.GetAllMenu6_7EbyDatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion

        #region"MENU6.7F"
        public List<Class6_7_F> GetAllMenu6_7F()
        {
            List<Class6_7_F> retlist = objDAL.GetAllMenu6_7F().ToList();
            return retlist;
        }

        public List<Class6_7_F> GetMenu6_7Fbydate(DateTime dtStart, DateTime dtStop)
        {
            List<Class6_7_F> retlist = objDAL.GetAllMenu6_7FbyDate(dtStart, dtStop).ToList();
            return retlist;
        }

        public List<Class6_7_F> GetMenu6_7Fbydatelimit(DateTime dtStart, DateTime dtStop, long limitrec, long currentPage)
        {
            List<Class6_7_F> retlist = objDAL.GetAllMenu6_7FbyDatelimit(dtStart, dtStop, limitrec, currentPage).ToList();
            return retlist;
        }
        #endregion
    }
}
