using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Game application modes.
    /// </summary>
    [Flags()]
    public enum ApplicationModes
    {
        /// <summary>
        /// None.
        /// </summary>
        DefaultMode = 0,

        /// <summary>
        /// Single player.
        /// </summary>
        SinglePlayer = 1,

        /// <summary>
        /// Online multiplayer.
        /// </summary>
        Online = 2,

        /// <summary>
        /// Lan Multiplayer.
        /// </summary>
        Multiplayer = 4,

        /// <summary>
        /// Settings.
        /// </summary>
        Settings = 8,

        /// <summary>
        /// Utility.
        /// </summary>
        Utility = 16,

        /// <summary>
        /// Game.
        /// </summary>
        Game = 32,

        /// <summary>
        /// Application.
        /// </summary>
        Application = 64,

        /// <summary>
        /// Free to play.
        /// </summary>
        FreeToPlay = 128,

        /// <summary>
        /// Requires subscription.
        /// </summary>
        RequiresSubscription = 256,

        /// <summary>
        /// Free trial.
        /// </summary>
        FreeTrial = 512,

        /// <summary>
        /// Split screen.
        /// </summary>
        SplitScreenMultiPlayer = 1024,

        /// <summary>
        /// Lan co-op.
        /// </summary>
        CoOpLan = 2048,

        /// <summary>
        /// Online co-op.
        /// </summary>
        CoOpOnline = 4096,

        /// <summary>
        /// One time purchase.
        /// </summary>
        OneTimePurchase = 8192,
    }
}
