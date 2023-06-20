﻿using System.Text.Json.Serialization;

namespace Sdcb.SparkDesk;

/// <summary>
/// Represents the payload containing the list of messages from the user and the assistant.
/// </summary>
public class Payload
{
    /// <summary>
    /// Contains a list of messages from the user and assistant. Each message must contain a role and content property.
    /// </summary>
    [JsonPropertyName("message")]
    public required Message Message { get; set; }
}