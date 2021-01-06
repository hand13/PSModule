using System;
using System.Management.Automation;

namespace MyModule
{
    [Cmdlet(VerbsCommunications.Write,"TimestampedMessage")]
    public class WriteTimestampedMessageCommand:PSCmdlet
    {
        [Parameter(Position = 1)]
        public string Message {get;set;} = string.Empty;
        [Parameter(Position = 2)]
        public int time{get;set;} = 1;
        [Parameter(Mandatory = false)]
        public Boolean greet = false;
        protected override void EndProcessing()
        {
            string timestamp = DateTime.Now.ToString();
            if(greet) {
                this.WriteObject("no you die");
            }
            for(int i = 0;i<time;i++) {
                this.WriteObject($"[{timestamp}] - {this.Message}");
            }
            base.EndProcessing();
        }
    }
}
