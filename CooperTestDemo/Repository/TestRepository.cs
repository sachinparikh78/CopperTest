using CooperTestDemo.Entities;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CooperTestDemo.Repository
{
    public class TestRepository : ITestRepository
    {
        private cooperTestContext db = new cooperTestContext();
        
        /**
         * Get all Active Tests  
         */
        public List<Tests> GetTests()
        {
            return db.Tests.Include(x=>x.AthleteTests).ToList();
        }

        public int getCount(int id)
        {
            return db.AthleteTests.Where(s => s.TestId == id && s.RecordStatus == Constants.ACTIVE).Count();
        }


        /**
         * Get all Active Athletes Already registered  
         */
        public List<Athlete> GetAthletes()
        {
            return db.Athlete.Where(s => s.RecordStatus == Constants.ACTIVE).ToList();
        }

        /**
         * Get All registered athletes for tests
         */
        public List<AthleteTests> GetAthleteTestsById(int? id)
        {
            var lst = db.AthleteTests.Where(s=>s.TestId == id && s.RecordStatus == Constants.ACTIVE).ToList();
            if (lst != null && lst.Count > 0)
                return lst;
            else
                return new List<AthleteTests>();
        }

        /**
         * Save / Update Tests Details
         */
        public CommonResp SaveTest(Tests t)
        {
            CommonResp msg = new CommonResp();
            try
            {
                if (t.Id > 0) { db.Tests.Update(t); } else { db.Tests.Add(t); }
                db.SaveChanges();
                msg.flag = true;
                msg.message = "Saved Successfully";
            }
            catch (Exception ex)
            {
                msg.flag = false;
                msg.message = ex.Message;
            }
            return msg;
        }

        /**
         * Save / Update Athlete Details
         */
        public CommonResp SaveAthelte(AthleteTests at)
        {
            CommonResp msg = new CommonResp();
            try
            {
                
                if (at.Id > 0) { db.AthleteTests.Update(at); } else { db.AthleteTests.Add(at);  }
                db.SaveChanges();
                msg.flag = true;
                msg.message = "Saved Successfully";
            }
            catch (Exception ex)
            {
                msg.flag = false;
                msg.message = ex.Message;
            }
            return msg;
        }

        /**
         *  Get Test Details
         */
        public Tests getTestById(int? id)
        {
            try
            {
                Tests tst = db.Tests.Where(s => s.Id == id && s.RecordStatus == "Active").FirstOrDefault();
                if (tst != null)
                    return tst;
                else
                    return new Tests();
            }
            catch (Exception ex)
            {
                return new Tests();
            }
        }


        /**
        *  Get Test Details
        */
        public AthleteTests GetAthleteTestById(int? id)
        {
            try
            {
                AthleteTests ath = db.AthleteTests.Where(s => s.Id == id && s.RecordStatus == "Active").FirstOrDefault();
                if (ath != null)
                    return ath;
                else
                    return new AthleteTests();
            }
            catch (Exception ex)
            {
                return new AthleteTests();
            }
        }

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    internal interface ITestRepository : IDisposable
    {
        List<Tests> GetTests();        
        List<AthleteTests> GetAthleteTestsById(int? id);
        List<Athlete> GetAthletes();
        AthleteTests GetAthleteTestById(int? id);
        CommonResp SaveTest(Tests t);
        CommonResp SaveAthelte(AthleteTests at);
        Tests getTestById(int? id);
    }
}
