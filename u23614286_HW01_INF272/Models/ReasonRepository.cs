using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23614286_HW01_INF272.Models
{
	public class ReasonRepository
	{
        public static List<Reason> Reasons = new List<Reason>()
        {
            new Reason
            {
                ReasonID = 1,
                Description = "Life-threatening situation"
            },
            new Reason
            {
                ReasonID = 2,
                Description = "Accident"
            },
            new Reason
            {
                ReasonID = 3,
                Description = "Someone is unconcscious"
            },
            new Reason
            {
                ReasonID = 4,
                Description = "Overdose"
            },
            new Reason
            {
                ReasonID=5,
                Description = "Other"
            }
        };

    }
}