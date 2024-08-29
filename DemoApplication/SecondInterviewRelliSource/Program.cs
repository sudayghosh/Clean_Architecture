// See https://aka.ms/new-console-template for more information
using SecondInterviewRelliSource;
using System.Linq;

Console.WriteLine("Hello, World!");

int[] nums = [3, 2, 4];
int target = 6;
Solution s = new Solution();
var result = s.RomanToInt("LVIII");


//List<VisitModel> GetVisitForms(List<Visit> visits, List<Form> forms, List<Guid> visitIds)
//{
//    var output = (from v in visits
//                  join f in forms on v.VisitId equals f.VisitId
//                  where visitIds.Contains(v.VisitId)
//                  select new VisitModel
//                  {
//                      VisitId = v.VisitId,
//                      VisitName = v.Name,
//                      Forms = forms.Where(w => w.VisitId == v.VisitId).ToList(),
//                  }).toList();

//    return output;
//}

////Input
//class Visit
//{
//    public Guid VisitId { get; set; }
//    public string Name { get; set; }
//}
//class Form
//{
//    public int FormId { get; set; }
//    public string FormName { get; set; }
//    public Guid VisitId { get; set; }
//}

////Output:
//class VisitModel
//{
//    public Guid VisitId { get; set; }
//    public string VisitName { get; set; }
//    List<Form> Forms { get; set; }
//}


//class TicketManagementSystem
//{
//    async Task BookTicket(User a, Ticket b)
//    {
//        if(await IsTicketAvailable(b))
//        {
//            lock (objec)
//            {
//                await BookTicket111(a, b);
//            }
//        }
//    }
//}

//5
//2 - 4
//3 

//async Task<int> F1()
//{
//    return 5;
//}
//async Task<int> F2()
//{ 
//    return 4;
//}

//async Task F()
//{
//    var x1 = F1();
//    var x2 = F2();
//    var output = await Task.WhenAll(x1, x2);
//    var sum = output[0] + output[1];
//}

//async Task<int> F1()
//{ }
//async Task<int> F2()
//{ }
//async Task F()
//{
//    var x1 = await F1();
//    var x2 = await F2();
//    var sum = x1 + x2;
//}



//List<Visit> list = new List<Visit>();
//list.Add(new Visit() { Id = 2, ParentVisitId = 1 });
//list.Add(new Visit() { Id = 3, ParentVisitId = 2 });
//list.Add(new Visit() { Id = 4, ParentVisitId = 2 });
//list.Add(new Visit() { Id = 5, ParentVisitId = 3 });

//List<Visit> lstFollowups = new List<Visit>();
//int visitorId = 2;

//GetFollowupVisitors(list, visitorId, lstFollowups);
//Console.WriteLine("Hello, World!");

//GetFollowupVisitors(List<Visit> lstVisits, int visitorId, List<Visit> lstFollowups)
//{
//    var childFollowups = lstVisits.Where(w => w.ParentVisitId == visitorId);
//    foreach (var childVisit in childFollowups)
//    {
//        lstFollowups.Add(childVisit);
//        GetFollowupVisitors(list, childVisit.Id, lstFollowups);
//    }
//}


//public class Visit
//{
//    public int Id { get; set; }
//    public int ParentVisitId { get; set; }
//}