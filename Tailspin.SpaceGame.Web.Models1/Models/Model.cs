﻿using System.Text.Json.Serialization;

namespace TailSpin.SpaceGame.Web.Models1
{
    /// <summary>
    /// Base class for data models.
    /// </summary>
    public abstract class Model
    {
        // The value that uniquely identifies this object.
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}