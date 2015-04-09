using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBuilder
{
    public partial class Form1 : Form
    {
        //FIELDS
        private String messageBeginMarker = "#";
        private String messageEndMarker = "%";

        private MessageBuilder messageBuilder;
        public Form1()
        {
            InitializeComponent();

            messageBuilder = new MessageBuilder(messageBeginMarker, messageEndMarker);
            messageBuilder.OnBufferedDataChanged += messageBuilder_OnBufferedDataChanged;
        }

        void messageBuilder_OnBufferedDataChanged(object sender, BufferedDataEventArgs e)
        {
            String[] allMessages = e.bufferedData.Split(Convert.ToChar(messageEndMarker));

            foreach (String message in allMessages)
            {
                if (message.Contains(messageBeginMarker) && message.Contains(messageEndMarker))
                {
                    
                }
            }

        }
    }
}
