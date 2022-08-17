namespace BlazorServerGridSample1.Data
{
    public class GanttService
    {
        public List<Gantt> GetGanttData()
        {
            var Gantts = new List<Gantt>();

            var item1 = new Gantt();
            item1.Name = "要件定義";
            item1.Day1 = 4;
            item1.Day2 = 8;
            item1.Day3 = 10;
            Gantts.Add(item1);

            var item2 = new Gantt();
            item2.Name = "基本設計";
            item2.Day4 = 8;
            item2.Day5 = 8;
            item2.Day6 = 8;
            Gantts.Add(item2);

            var item3 = new Gantt();
            item3.Name = "詳細設計";
            item3.Day7 = 10;
            item3.Day8 = 10;
            item3.Day9 = 10;
            item3.Day10 = 8;
            Gantts.Add(item3);

            var item4 = new Gantt();
            item4.Name = "開発工程1";
            item4.Day11 = 8;
            item4.Day12 = 8;
            item4.Day13 = 10;
            item4.Day14 = 10;
            item4.Day15 = 10;
            item4.Day16 = 8;
            item4.Day17 = 8;
            Gantts.Add(item4);

            var item5 = new Gantt();
            item5.Name = "開発工程2";
            item5.Day18 = 8;
            item5.Day19 = 8;
            item5.Day20 = 8;
            item5.Day21 = 8;
            item5.Day22 = 8;
            item5.Day23 = 8;
            item5.Day24 = 4;
            item5.Day25 = 4;
            Gantts.Add(item5);


            return Gantts;
        }
    }
}
