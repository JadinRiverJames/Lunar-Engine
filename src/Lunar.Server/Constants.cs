﻿/** Copyright 2018 John Lamontagne https://www.mmorpgcreation.com

	Licensed under the Apache License, Version 2.0 (the "License");
	you may not use this file except in compliance with the License.
	You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0

	Unless required by applicable law or agreed to in writing, software
	distributed under the License is distributed on an "AS IS" BASIS,
	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	See the License for the specific language governing permissions and
	limitations under the License.
*/
using System;

namespace Lunar.Server
{
    public static class Constants
    {
        public static readonly string FILEPATH_DATA = AppDomain.CurrentDomain.BaseDirectory + "/Data/";

        public static readonly string FILEPATH_ACCOUNTS = FILEPATH_DATA + "/Accounts/";

        public static readonly string FILEPATH_SCRIPTS = FILEPATH_DATA + "/Scripts/";

        public static readonly string FILEPATH_PLUGINS = FILEPATH_DATA + "/Plugins/";

        public static readonly string FILEPATH_NPCS = FILEPATH_DATA + "/Npcs/";

        public static readonly string FILEPATH_LOGS = FILEPATH_DATA + "/Logs/";

        public static readonly string FILEPATH_ITEMS = FILEPATH_DATA + "/Items/";

        public static readonly string FILEPATH_MAPS = FILEPATH_DATA + "/Maps/";

        public const int MAP_ITEM_WIDTH = 32;

        public const int MAP_ITEM_HEIGHT = 32;

        public const int MAX_QUEUED_ACTIONS = 10;

        public const int ACTIONS_PER_SECOND = 5;
    }
}