using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CRM.Application.Common
{
    public class Result
    {
        public Result()
        {
            Succeeded = true;
            Errors = new string[] { };
        }

        public Result(bool succeeded, IEnumerable<string> errors)
        {
            Succeeded = succeeded;
            Errors = errors.ToArray();
        }

        public Result(bool succeeded, string error)
        {
            Succeeded = succeeded;
            Errors = new string[] { error };
        }

        public bool Succeeded { get; set; }

        public string[] Errors { get; set; }

        public static Result Success()
        {
            return new Result(true, new string[] { });
        }

        public static Result Failure(IEnumerable<string> errors)
        {
            return new Result(false, errors);
        }

        public static Result Failure(string error)
        {
            return new Result(false, error);
        }

        public void SetErrors(IEnumerable<string> errors)
        {
            Succeeded = false;
            Errors = errors.ToArray();
        }

        public void SetErrors(IEnumerable<IdentityError> errors)
        {
            Succeeded = false;
            Errors = (from e in errors select "CODE " + e.Code + " DESCRIPTION: " + e.Description).ToArray();
        }

        public void SetError(string error)
        {
            Succeeded = false;
            Errors = new string[] { error };
        }
    }
}
