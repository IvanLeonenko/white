﻿using NUnit.Framework;
using White.Core.CustomCommands;
using White.Core.UIItems.ListBoxItems;
using White.WebBrowser.UITests;

namespace White.CustomCommands.SilverlightTests
{
    [TestFixture]
    public class CustomComboBoxCommandSilverlightTest : SilverlightTestFixture
    {
        [Test]
        public void Select()
        {
            var comboBox = browserWindow.SilverlightDocument.Get<ComboBox>("custom_combo");
            var comboBoxCommands = new CustomCommandFactory().Create<IComboBoxCommands>(comboBox);
            comboBoxCommands.Select("Quux");
            Assert.AreEqual("Quux", comboBox.SelectedItemText);
            comboBoxCommands.Select("Quux");
            Assert.AreEqual("Quux", comboBox.SelectedItemText);
        }
    }
}