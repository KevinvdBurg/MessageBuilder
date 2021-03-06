﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            String receivedData = e.bufferedData;
            string pattern = @"(?<=[" + messageEndMarker + "])";
            String[] allMessages = Regex.Split(receivedData, pattern);
            lbAllMessages.Items.Clear();
            foreach (String message in allMessages)
            {
                if (message != null && message != "")
                {
                    if (message.Contains(messageBeginMarker) && message.Contains(messageEndMarker))
                    {
                        lbAllMessages.Items.Add(message.Substring(1).TrimEnd(Convert.ToChar(messageEndMarker)));
                    }    
                }
            }

        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            String mess = tbMessage.Text;
            messageBuilder.Append(mess);
        }
    }
}
