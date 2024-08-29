// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using TestRelisource;

class Program
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        //Console.WriteLine(args.Length);
        //Console.WriteLine("Hello, World!");
        //BenchmarkRunner.Run<Benchmarks>();

        List<Visit> list = new List<Visit>();
        list.Add(new Visit() { Id = 2, ParentVisitId = 1 });
        list.Add(new Visit() { Id = 3, ParentVisitId = 2 });
        list.Add(new Visit() { Id = 4, ParentVisitId = 2 });
        list.Add(new Visit() { Id = 5, ParentVisitId = 3 });

        List<Visit> lstFollowups = new List<Visit>();
        int visitorId = 2;

        GetFollowupVisitors(list, visitorId);

        void GetFollowupVisitors(List<Visit> lstVisits, int visitorId)
        {
            var childFollowups = lstVisits.Where(w => w.ParentVisitId == visitorId);
            foreach (var childVisit in childFollowups)
            {
                lstFollowups.Add(childVisit);
                GetFollowupVisitors(list, childVisit.Id);
            }
        }

        #region Commented

        //Node n = new Node
        //{ 
        //    Value = 5,
        //    ChildNodes = new List<Node>
        //    { 
        //        new Node
        //        { 
        //            Value = 10,
        //            ChildNodes = new List<Node>
        //            { 
        //                new Node
        //                { 
        //                    Value = 3
        //                },
        //                new Node
        //                {
        //                    Value = 7
        //                }
        //            }
        //        },
        //        new Node
        //        {
        //            Value = 11,
        //            ChildNodes = new List<Node>
        //            {
        //                new Node
        //                {
        //                    Value = 50,
        //                    ChildNodes = new List<Node>
        //                    { 
        //                        new Node
        //                        { 
        //                            Value = 6
        //                        },
        //                        new Node
        //                        {
        //                            Value = 9
        //                        },
        //                        new Node
        //                        {
        //                            Value = 10
        //                        }
        //                    }
        //                },
        //                new Node
        //                {
        //                    Value = 50
        //                }
        //            }
        //        }
        //    }
        //};


        //int indent = 1;
        //PrintNode(n, indent);


        //void PrintNode(Node n, int indent)
        //{
        //    Console.WriteLine($"${GetIndentText(indent)}{n.Value}");
        //    if (n.ChildNodes != null)
        //    {
        //        indent++;
        //        foreach (Node childNode in n.ChildNodes)
        //        {
        //            PrintNode(childNode, indent);
        //        }
        //    }
        //}

        //string GetIndentText(int indent)
        //{
        //    string text = "";
        //    for (int i = 0; i < indent; i++)
        //    {
        //        text = text + "-";
        //    }
        //    return text;
        //}


        //public class Node
        //{
        //    public int Value { get; set; }

        //    public List<Node> ChildNodes { get; set; }
        //}

        //Benchmarks benchmarks = new Benchmarks();
        //benchmarks.NewList();
        //benchmarks.CollExpressions();

        //var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

        //        List<MeetingRoom> meetingRoomList = new List<MeetingRoom>
        //{
        //    new MeetingRoom
        //    {
        //        Start = 5, End = 12,
        //    },
        //    new MeetingRoom
        //    {
        //        Start = 1, End = 4,
        //    },
        //    new MeetingRoom
        //    {
        //        Start = 2, End = 5,
        //    },
        //    new MeetingRoom
        //    {
        //        Start = 9, End = 120,
        //    },
        //    new MeetingRoom
        //    {
        //        Start = 5, End = 9,
        //    }
        //};

        //        Func<MeetingRoom, int> tempDiff = x => x.End - x.Start;
        //        var day = meetingRoomList.Aggregate((a, b) => tempDiff(a) < tempDiff(b) ? a : b);

        //        var ss = meetingRoomList.OrderBy(x => x.End - x.Start).First();
        //        Console.WriteLine(ss.End - ss.Start);
        //        Console.ReadLine();

        #endregion

    }

    public class Visit
    {
        public int Id { get; set; }
        public int ParentVisitId { get; set; }
    }

    public class MeetingRoom
    {
        public int Start { get; set; }
        public int End { get; set; }
    }
}