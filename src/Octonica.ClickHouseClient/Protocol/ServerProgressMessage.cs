﻿#region License Apache 2.0
/* Copyright 2019-2020 Octonica LLC
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

using System.Threading;
using System.Threading.Tasks;

namespace Octonica.ClickHouseClient.Protocol
{
    internal sealed class ServerProgressMessage : IServerMessage
    {
        public ServerMessageCode MessageCode => ServerMessageCode.Progress;

        public int Rows { get; }

        public int Bytes { get; }

        public int Totals { get; }

        public int WrittenRows { get; }

        public int WrittenBytes { get; }

        private ServerProgressMessage(int rows, int bytes, int totals, int writtenRows, int writtenBytes)
        {
            Rows = rows;
            Bytes = bytes;
            Totals = totals;
            WrittenRows = writtenRows;
            WrittenBytes = writtenBytes;
        }

        public static async ValueTask<ServerProgressMessage> Read(ClickHouseBinaryProtocolReader reader, bool async, CancellationToken cancellationToken)
        {
            int rows = await reader.Read7BitInt32(async, cancellationToken);
            int bytes = await reader.Read7BitInt32(async, cancellationToken);
            int totals = await reader.Read7BitInt32(async, cancellationToken);
            int writtenRows = await reader.Read7BitInt32(async, cancellationToken);
            int writtenBytes = await reader.Read7BitInt32(async, cancellationToken);

            return new ServerProgressMessage(rows, bytes, totals, writtenRows, writtenBytes);
        }
    }
}
