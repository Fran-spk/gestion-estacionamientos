using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.OLE.Interop;

public class ActivityMessageFilter : System.Windows.Forms.IMessageFilter
{
    public Action OnUserActivity;

    public bool PreFilterMessage(ref Message m)
    {
        const int WM_MOUSEMOVE = 0x0200;
        const int WM_LBUTTONDOWN = 0x0201;
        const int WM_RBUTTONDOWN = 0x0204;
        const int WM_KEYDOWN = 0x0100;
        const int WM_MOUSEWHEEL = 0x020A;

        if (m.Msg == WM_MOUSEMOVE ||
            m.Msg == WM_LBUTTONDOWN ||
            m.Msg == WM_RBUTTONDOWN ||
            m.Msg == WM_KEYDOWN ||
            m.Msg == WM_MOUSEWHEEL)
        {
            OnUserActivity?.Invoke();
        }

        return false; 
    }
}
