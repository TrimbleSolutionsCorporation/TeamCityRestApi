// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueueBuild.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the QueueBuild type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace TeamcityRestTypes
{
    using System;

    public class TcComment
    {
        public string Text { get; set; }

        public string User { get; set; }

        public string UserName { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}