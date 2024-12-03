using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using note;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Note_Name_Set_Correct()
        {
            try
            {
                Note note = new Note();
                note.Name = "Тестовая заметка";
                note.Name = "Test Name";
                note.Name = "111111111111";
                Console.WriteLine("Тест задания названия заметки: пройден");
            }
            catch (Exception e)
            {
                Console.WriteLine("Тест задания названия заметки: провален");
            }
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Note_Name_Set_Uncorrect()
        {
            Note note = new Note();
            note.Name =
                "Тестовая заметка с длинным названием более 15 символов";
        }
        [TestMethod]
        public void Test_Note_Name_Set_Uncorrect()
        {
            Assert.ThrowsException<ArgumentException>(() => Note_Name_Set_Uncorrect());
        }
        public void Test_Note_Last_Changed_Time()
        {
            Note note = new Note();
            note.Name = "Тестовая заметка";
            DateTime before = note.LastChangedTime;
            Thread.Sleep(20);
            DateTime after = note.LastChangedTime;
            if (!(after < before))
                Console.WriteLine("Тест даты изменения заметки: провален");
            else
                Console.WriteLine("Тест даты изменения заметки: пройден");
            Assert.AreNotEqual(after, before);
        }
    }
}
