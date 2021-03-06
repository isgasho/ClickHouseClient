﻿#region License Apache 2.0
/* Copyright 2019-2020 Octonica
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
#endregion

namespace Octonica.ClickHouseClient.Exceptions
{
    public static class ClickHouseErrorCodes
    {
        public const int Unspecified = 0;
        public const int ServerError= 1;
        public const int InvalidConnectionState = 2;
        public const int ConnectionClosed = 3;
        public const int ProtocolUnexpectedResponse = 4;
        public const int ProtocolRevisionNotSupported = 5;
        public const int TypeNotSupported = 6;
        public const int InvalidTypeName = 7;
        public const int TypeNotFullySpecified = 8;
        public const int QueryTypeMismatch = 9;
        public const int DataReaderError = 10;
        public const int QueryParameterNotFound = 11;
        public const int InvalidQueryParameterConfiguration = 12;
        public const int ColumnMismatch = 13;
        public const int InternalError = 14;
        public const int CompressionDecoderError = 15;
        public const int NetworkError = 16;
    }
}
