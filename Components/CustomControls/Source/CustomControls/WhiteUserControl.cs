using System.Windows.Automation.Peers;
using System.Windows.Controls;
using White.CustomControls.Peers;

namespace White.CustomControls
{
    public class WhiteUserControl : UserControl
    {
        protected override AutomationPeer OnCreateAutomationPeer()
        {
            return new WhiteUserControlPeer(this);
        }
    }
}