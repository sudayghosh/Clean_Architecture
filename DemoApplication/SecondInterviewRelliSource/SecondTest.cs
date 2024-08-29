//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SecondInterviewRelliSource
//{
//    internal class SecondTest
//    {
//        List<Visit> lstFollowups = new List<Visit>();
//        List<Visit> list = new List<Visit>();
//        public SecondTest()
//        {
//            list.Add(new Visit() { Id = 2, ParentVisitId = 1 });
//            list.Add(new Visit() { Id = 3, ParentVisitId = 2 });
//            list.Add(new Visit() { Id = 4, ParentVisitId = 2 });
//            list.Add(new Visit() { Id = 5, ParentVisitId = 3 });

//            int visitorId = 2;

//            GetFollowupVisitors(list, visitorId);
//            Console.WriteLine("Hello, World!");
//        }

//        public void GetFollowupVisitors(List<Visit> lstVisits, int visitorId)
//        {
//            var childFollowups = lstVisits.Where(w => w.ParentVisitId == visitorId);
//            foreach (var childVisit in childFollowups)
//            {
//                lstFollowups.Add(childVisit);
//                GetFollowupVisitors(list, childVisit.Id);
//            }
//        }
//    }
//}

//public class Visit
//{
//    public int Id { get; set; }
//    public int ParentVisitId { get; set; }
//}