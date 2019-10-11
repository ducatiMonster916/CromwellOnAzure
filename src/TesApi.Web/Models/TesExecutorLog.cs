// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

/*
 * Task Execution Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.3.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace TesApi.Models
{
    /// <summary>
    /// ExecutorLog describes logging information related to an Executor.
    /// </summary>
    [DataContract]
    public partial class TesExecutorLog : IEquatable<TesExecutorLog>
    {
        /// <summary>
        /// Time the executor started, in RFC 3339 format.
        /// </summary>
        /// <value>Time the executor started, in RFC 3339 format.</value>
        [DataMember(Name = "start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// Time the executor ended, in RFC 3339 format.
        /// </summary>
        /// <value>Time the executor ended, in RFC 3339 format.</value>
        [DataMember(Name = "end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// Stdout content.  This is meant for convenience. No guarantees are made about the content. Implementations may chose different approaches: only the head, only the tail, a URL reference only, etc.  In order to capture the full stdout users should set Executor.stdout to a container file path, and use Task.outputs to upload that file to permanent storage.
        /// </summary>
        /// <value>Stdout content.  This is meant for convenience. No guarantees are made about the content. Implementations may chose different approaches: only the head, only the tail, a URL reference only, etc.  In order to capture the full stdout users should set Executor.stdout to a container file path, and use Task.outputs to upload that file to permanent storage.</value>
        [DataMember(Name = "stdout")]
        public string Stdout { get; set; }

        /// <summary>
        /// Stderr content.  This is meant for convenience. No guarantees are made about the content. Implementations may chose different approaches: only the head, only the tail, a URL reference only, etc.  In order to capture the full stderr users should set Executor.stderr to a container file path, and use Task.outputs to upload that file to permanent storage.
        /// </summary>
        /// <value>Stderr content.  This is meant for convenience. No guarantees are made about the content. Implementations may chose different approaches: only the head, only the tail, a URL reference only, etc.  In order to capture the full stderr users should set Executor.stderr to a container file path, and use Task.outputs to upload that file to permanent storage.</value>
        [DataMember(Name = "stderr")]
        public string Stderr { get; set; }

        /// <summary>
        /// Exit code.
        /// </summary>
        /// <value>Exit code.</value>
        [DataMember(Name = "exit_code")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TesExecutorLog {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Stdout: ").Append(Stdout).Append("\n");
            sb.Append("  Stderr: ").Append(Stderr).Append("\n");
            sb.Append("  ExitCode: ").Append(ExitCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == GetType() && Equals((TesExecutorLog)obj);
        }

        /// <summary>
        /// Returns true if TesExecutorLog instances are equal
        /// </summary>
        /// <param name="other">Instance of TesExecutorLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TesExecutorLog other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return
                (
                    StartTime == other.StartTime ||
                    StartTime != null &&
                    StartTime.Equals(other.StartTime)
                ) &&
                (
                    EndTime == other.EndTime ||
                    EndTime != null &&
                    EndTime.Equals(other.EndTime)
                ) &&
                (
                    Stdout == other.Stdout ||
                    Stdout != null &&
                    Stdout.Equals(other.Stdout)
                ) &&
                (
                    Stderr == other.Stderr ||
                    Stderr != null &&
                    Stderr.Equals(other.Stderr)
                ) &&
                (
                    ExitCode == other.ExitCode ||
                    ExitCode != null &&
                    ExitCode.Equals(other.ExitCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (StartTime != null)
                {
                    hashCode = hashCode * 59 + StartTime.GetHashCode();
                }

                if (EndTime != null)
                {
                    hashCode = hashCode * 59 + EndTime.GetHashCode();
                }

                if (Stdout != null)
                {
                    hashCode = hashCode * 59 + Stdout.GetHashCode();
                }

                if (Stderr != null)
                {
                    hashCode = hashCode * 59 + Stderr.GetHashCode();
                }

                if (ExitCode != null)
                {
                    hashCode = hashCode * 59 + ExitCode.GetHashCode();
                }

                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(TesExecutorLog left, TesExecutorLog right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TesExecutorLog left, TesExecutorLog right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
