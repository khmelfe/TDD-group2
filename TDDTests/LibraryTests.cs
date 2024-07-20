using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TDD.Tests
{
    [TestClass()]
    public class LibraryTests
    {
        [TestMethod()]
        public void Exit_button_ClickTest()
        {
            Assert.Fail();
        }
    }
}
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using TDD;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Microsoft.VisualStudio.TestTools.UnitTesting;



//namespace TDD.Tests
//{
//    [TestClass()]
//    public class LibraryTests
//    {
//        [TestMethod()]
//        public void Exit_button_Click_No_DoesNotCloseForm()
//        {
//            // Arrange
//            var form = new Library();
//            var exitButton = new Button();
//            form.Controls.Add(exitButton);

//            // Simulate the user clicking "No" on the MessageBox
//            MessageBoxManager.Yes = "Yes";
//            MessageBoxManager.No = "No";
//            MessageBoxManager.Register();
//            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Critical decision.", MessageBoxButtons.YesNo);
//            if (result == DialogResult.No)
//            {
//                // Act
//                PRIVA
//                privateObject.Invoke("Exit_button_Click", exitButton, EventArgs.Empty);

//                // Assert
//                Assert.IsFalse(form.IsDisposed);
//            };
//        }
//    }
//}