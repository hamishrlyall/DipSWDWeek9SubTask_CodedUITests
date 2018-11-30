namespace CodedUITestProject1
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {
        public UIMap()
        {
            this.UIMainWindowWindow.UIStartButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "buttonA";
        }

        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void ModifiedRecordedMethod1()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WinButton uICloseButton = this.UIMainWindowWindow1.UICloseButton;
            #endregion

            // Launch '%USERPROFILE%\source\repos\DipSWDWeek9SubTask_CodedUITests\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.RecordedMethod1Params.UIMainWindowWindowExePath, this.RecordedMethod1Params.UIMainWindowWindowAlternateExePath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(39, 12));

            uICheckBoxCheckBox.WaitForControlEnabled();

            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.RecordedMethod1Params.UICheckBoxCheckBoxChecked;

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(24, 20));
        }

        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }

        private RecordedMethod1Params mRecordedMethod1Params;
    }
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class RecordedMethod1Params
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\source\repos\DipSWDWeek9SubTask_CodedUITests\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowExePath = "C:\\Users\\hamis\\source\\repos\\DipSWDWeek9SubTask_CodedUITests\\SimpleWPFApp\\bin\\Debu" +
            "g\\SimpleWPFApp.exe";

        /// <summary>
        /// Launch '%USERPROFILE%\source\repos\DipSWDWeek9SubTask_CodedUITests\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowAlternateExePath = "%USERPROFILE%\\source\\repos\\DipSWDWeek9SubTask_CodedUITests\\SimpleWPFApp\\bin\\Debug" +
            "\\SimpleWPFApp.exe";

        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
}
