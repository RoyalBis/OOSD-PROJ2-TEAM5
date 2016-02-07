using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
Title:                Result.cs  
 Project:          Travel Experts Desktop App
Authors:         Royal Bissell, Kevin Liao, Annie Ali, Lee Harrold
Class:               OOSD Fall 2015 
Date:               2016/02/07
Description: Simple Object Class that holds a string (message) and a bool (success/failure)
                          This object can be used for all returns that need to return a bool and a message.
                          Currently this is being used for the Data Validation class.
**********************************************************************/

namespace Validation
{
    /// <summary>
    /// Result object, holds a message and a success bool
    /// </summary>
    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public Result(bool success, string message = "")
        {
            this.Success = success;
            this.Message = message;
        }
    }
}
