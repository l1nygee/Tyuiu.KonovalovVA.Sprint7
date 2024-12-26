using Tyuiu.KonovalovVA.Sprint7.Project.V8.Lib;

namespace Tyuiu.KonovalovVA.Sprint7.Project.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FileLoadedTest()
        {
            var ds = new DataService();
            string path = @"C:\DataSprint7\AutoTest.csv";
            List<string[]> wait = new List<string[]>();
            wait.Add(new string[] { "312", "������ ����", "���� ��������", "1998", "250", "���", "������������� �������� � �����, ������� � ������ ��������" });
            wait.Add(new string[] { "14", "���� �����", "��� ��������", "2021", "480", "��", "������-�������������� ������� � ���������� ����������" });

            List<string[]> fileLines = new List<string[]>();
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    int count = 0;
                    while ((line = reader.ReadLine()) != null && count < 2)
                    {
                        string[] fileLine = line.Split(';');
                        fileLines.Add(fileLine);
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                Assert.Fail($"��������� ������ ��� ������ �����: {ex.Message}");
                return;
            }

            Assert.IsTrue(AreEqual(wait[0], fileLines[0]), "������ ������ �� ���������.");
            Assert.IsTrue(AreEqual(wait[1], fileLines[1]), "������ ������ �� ���������.");
        }
        private bool AreEqual(string[] arr1, string[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }
    }
}