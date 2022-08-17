namespace BlazorServerGridSample1.Data
{
    public class GanttService
    {
        public List<Gantt> GetGanttData()
        {
            var Gantts = new List<Gantt>();

            var item1 = new Gantt();
            item1.Name = "要件定義";
            item1.Day1 = "1";
            item1.Day2 = "1";
            item1.Day3 = "1";
            Gantts.Add(item1);

            var item2 = new Gantt();
            item2.Name = "基本設計";
            item2.Day4 = "1";
            item2.Day5 = "1";
            item2.Day6 = "1";
            Gantts.Add(item2);

            var item3 = new Gantt();
            item3.Name = "詳細設計";
            item3.Day7 = "1";
            item3.Day8 = "1";
            item3.Day9 = "1";
            item3.Day10 = "1";
            Gantts.Add(item3);

            var item4 = new Gantt();
            item4.Name = "開発工程1";
            item4.Day11 = "1";
            item4.Day12 = "1";
            item4.Day13 = "1";
            item4.Day14 = "1";
            item4.Day15 = "1";
            item4.Day16 = "1";
            item4.Day17 = "1";
            Gantts.Add(item4);

            var item5 = new Gantt();
            item5.Name = "開発工程2";
            item5.Day18 = "1";
            item5.Day19 = "1";
            item5.Day20 = "1";
            item5.Day21 = "1";
            item5.Day22 = "1";
            item5.Day23 = "1";
            item5.Day24 = "1";
            item5.Day25 = "1";
            Gantts.Add(item5);


            return Gantts;
        }
    }
}
