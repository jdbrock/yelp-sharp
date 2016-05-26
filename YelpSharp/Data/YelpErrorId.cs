using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
    public enum YelpErrorId
    {
        INTERNAL_ERROR,
        EXCEEDED_REQS,
        MISSING_PARAMETER,
        INVALID_PARAMETER,
        INVALID_SIGNATURE,
        INVALID_CREDENTIALS,
        INVALID_OAUTH_CREDENTIALS,
        ACCOUNT_UNCONFIRMED,
        PASSWORD_TOO_LONG,
        UNAVAILABLE_FOR_LOCATION,
        AREA_TOO_LARGE,
        MULTIPLE_LOCATIONS,
        BUSINESS_UNAVAILABLE,
        UNSPECIFIED_LOCATION
    }
}
