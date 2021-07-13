using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;
using Tasks;

namespace TestCases
{
    [TestClass]
    public class Task09Test
    {
        Task09 T09;
        [TestMethod]
        public void Test1()
        {
            T09 = new Task09();
            if (!(T09 is INotifyPropertyChanged))
                Assert.Fail();
        }

        [TestMethod]
        public void Test2()
        {
            T09 = new Task09();
            if (T09 is INotifyPropertyChanged iT09)
            {
                iT09.PropertyChanged += T09_PropertyChanged2;
                T09.MyProperty = 8;

                if (!T09.MyProperty.Equals(7))
                    Assert.Fail();
            }
            else
                Assert.Fail();
        }
        private void T09_PropertyChanged2(object sender, PropertyChangedEventArgs e)
        {
            (T09 as INotifyPropertyChanged).PropertyChanged -= T09_PropertyChanged2;
            if (!T09.MyProperty.Equals(8))
                Assert.Fail();
            else
                T09.MyProperty = 7;
        }

        [TestMethod]
        public void Test3()
        {
            T09 = new Task09();
            if (T09 is INotifyPropertyChanged iT09)
            {
                iT09.PropertyChanged += T09_PropertyChanged3;
                T09.MyProperty = 8;

                if (!T09.MyProperty.Equals(7))
                    Assert.Fail();
            }
            else
                Assert.Fail();
        }
        private void T09_PropertyChanged3(object sender, PropertyChangedEventArgs e)
        {
            (T09 as INotifyPropertyChanged).PropertyChanged -= T09_PropertyChanged3;
            if (!e.PropertyName.Equals("MyProperty") || !T09.MyProperty.Equals(8))
                Assert.Fail();
            else
                T09.MyProperty = 7;
        }
    }
}