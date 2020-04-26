﻿// This file is part of CovidTracer.
//
// CovidTracer is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// CovidTracer is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with CovidTracer. If not, see<https://www.gnu.org/licenses/>.

using CovidTracer.Models.Keys;
using CovidTracer.Models.Time;

namespace CovidTracer.Models
{
    public enum CaseType
    {
        Symptomatic, Positive
    }

    /** A `Symptomatic` or `Positive` case being contagious on the given day,
     * as returned by the backend.
     */
    public class Case
    {
        public readonly DailyTracerKey Key;
        public readonly CaseType Type;
        public readonly Date Day;

        public Case(DailyTracerKey key_, CaseType type_, Date day_)
        {
            Key = key_;
            Type = type_;
            Day = day_;
        }
    }
}
