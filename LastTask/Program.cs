namespace LastTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Susiraskite internete funkcionalumą gauti sąrašą failų iš nurodytos direktorijos.
            //Parašykit LINQ funkcionalumą gauti visus failų extensionus(pvz.: .txt, .csproj)
            //Parašykit LINQ funkcionalumą gauti visus tekstinius failus(.txt)
            //Parašykit LINQ funkcionalumą gauti pavadinimus visų teksinių failų direktorijoje(turi būti tik failo pavadinimas pvz.: ‘text.txt’)


            // var sar = Directory.GetFiles("C:\\Users\\elzbieta\\Documents\\ShareX\\Screenshots\\2022-12");
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\elzbieta\Documents\ShareX\Screenshots\2022-12");

            var list1 = d.GetFiles().Select(fileInfo => fileInfo.Extension).Distinct();
            var list2 = d.GetFiles().Where(x => x.Extension == ".txt").Select(x => x.Name);

           

        }
    }
}