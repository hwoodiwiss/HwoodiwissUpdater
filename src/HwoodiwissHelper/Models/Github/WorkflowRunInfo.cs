﻿namespace HwoodiwissHelper.Models.Github;

public sealed record WorkflowRunInfo(
    Actor Actor,
    string ArtifactsUrl,
    string CancelUrl,
    long CheckSuiteId,
    string CheckSuiteNodeId,
    string CheckSuiteUrl,
    WorkflowConclusion? Conclusion,
    string CreatedAt,
    string Event,
    string? HeadBranch,
    string HeadSha,
    string HtmlUrl,
    long Id,
    string JobsUrl,
    string LogsUrl,
    string? Name,
    string NodeId,
    string Path,
    string? PreviousAttemptUrl,
    string RerunUrl,
    int RunAttempt,
    int RunNumber,
    string RunStartedAt,
    WorkflowStatus Status,
    Actor? TriggeringActor,
    string UpdatedAt,
    string Url,
    int WorkflowId,
    string WorkflowUrl);
