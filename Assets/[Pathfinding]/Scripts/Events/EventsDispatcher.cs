﻿using System;
using BrunoMikoski.Pahtfinding.Grid;

namespace BrunoMikoski.Events
{
    public static class EventsDispatcher
    {
        public static class Grid
        {
            public static Action<int, int, int, TileType> OnTileTypeChangedEvent;

            public static void DispatchOnTileTypeChangedEvent(int index, int x, int y, TileType targetType )
            {
                if ( OnTileTypeChangedEvent != null )
                    OnTileTypeChangedEvent( index, x, y, targetType );
            }
        }

        public static class Interaction
        {

            public static Action<int, int> OnUserClickOnTilePositionEvent;
            public static void DispatchOnUserClickOnTilePositionEvent( int targetX, int targetZ )
            {
                if ( OnUserClickOnTilePositionEvent != null )
                    OnUserClickOnTilePositionEvent( targetX, targetZ );
            }
        }
    }
}