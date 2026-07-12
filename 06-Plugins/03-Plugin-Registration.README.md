# Plugin Registration

## Overview

Plugin Registration is the process of deploying a compiled Plugin Assembly (DLL) into Microsoft Dynamics 365 so that custom business logic executes automatically 
when platform events such as **Create**, **Update**, or **Delete** occur.

The Plugin Registration Tool (PRT) is used to register plugin assemblies and configure the execution pipeline.

---

## Learning Objectives

After completing this module, you will be able to:

- Understand Plugin Registration in Dynamics 365
- Register a Plugin Assembly
- Register Plugin Steps
- Configure execution pipeline stages
- Deploy plugins using Plugin Registration Tool
- Test plugin execution

---

## Prerequisites

Before registering a plugin, ensure the following are completed:

- Visual Studio 2022 installed
- Class Library (.NET Framework) project created
- Microsoft.Xrm.Sdk.dll referenced
- Plugin class implemented using `IPlugin`
- Assembly signed with a Strong Name Key (.snk)
- Project built successfully
- Plugin Registration Tool installed
- Access to a Dynamics 365 environment

---

# Plugin Registration Workflow

```text
Create Class Library
        │
        ▼
Write Plugin Code
        │
        ▼
Add CRM SDK References
        │
        ▼
Sign Assembly
        │
        ▼
Build Project
        │
        ▼
Generate DLL
        │
        ▼
Open Plugin Registration Tool
        │
        ▼
Connect to Dynamics 365
        │
        ▼
Register Assembly
        │
        ▼
Register Plugin Step
        │
        ▼
Test Plugin
```

---

# Registering the Plugin Assembly

After building the Class Library project, Visual Studio generates a DLL file.

Example output:

```text
bin
└── Debug
    └── ASK1026Plugin.dll
```

Open **Plugin Registration Tool** and create a new connection to your Dynamics 365 environment.

Choose:

```
Register
    ↓
Register New Assembly
```

Browse and select the generated DLL.

Click:

```
Register Selected Plugins
```

---

# Registering the Plugin Step

Once the assembly is registered, register a new execution step.

Typical configuration:

| Property | Value |
|----------|-------|
| Message | Create |
| Primary Entity | sud_sudpluginpractice |
| Stage | PreOperation |
| Execution Mode | Synchronous |
| Deployment | Server |

Finally, click **Register New Step**.

---

# Execution Pipeline

```text
User Creates Record
        │
        ▼
Plugin Step Triggered
        │
        ▼
Plugin Executes
        │
        ▼
Business Logic Runs
        │
        ▼
Record Saved
```

---

# Execution Stages

| Stage | Description |
|--------|-------------|
| PreValidation | Executes before platform validation |
| PreOperation | Executes before the record is committed to the database |
| PostOperation | Executes after the record is saved |

For this project, the plugin is registered in the **PreOperation** stage.

---

# Assembly Signing

Dynamics 365 requires plugin assemblies to be strongly signed.

Navigation:

```text
Project
    ↓
Properties
    ↓
Signing
    ↓
Sign the Assembly
    ↓
Create New Strong Name Key
```

After signing, rebuild the project before registration.

---

# Testing

Create a new record in the target entity.

Example:

| Field | Value |
|-------|-------|
| First Name | Sudheer |
| Last Name | Varma |

Expected Result:

| Field | Value |
|-------|-------|
| Full Name | Sudheer Varma |

---

# Common Issues

## Plugin Does Not Execute

Possible reasons:

- Assembly not registered
- Step not registered
- Incorrect Primary Entity
- Wrong Message selected
- Incorrect Pipeline Stage

---

## DLL Not Generated

Possible reasons:

- Project not built successfully
- Compilation errors
- Assembly not signed

---

## Strong Name Key Error

If Visual Studio displays:

```
The operation could not be completed.
```

Run Visual Studio as **Administrator** and create the Strong Name Key again.

---

## Required Field Validation

If **Full Name** is configured as **Business Required**, Dynamics 365 validates the field before the plugin executes.

Set the field to **Optional** so the plugin can populate the value during execution.

---

# Best Practices

- Sign every plugin assembly.
- Use meaningful assembly names.
- Keep one business requirement per plugin.
- Register only required steps.
- Test plugins after deployment.
- Enable tracing for debugging.
- Use source control for plugin projects.

---

# Interview Questions

### What is Plugin Registration?

Plugin Registration is the process of deploying a compiled DLL into Dynamics 365 and configuring when the plugin should execute.

---

### Why is Assembly Signing required?

Dynamics 365 accepts only strongly signed plugin assemblies for deployment.

---

### What is the difference between Assembly and Step?

**Assembly**

- Contains compiled plugin code (DLL)

**Step**

- Defines when and where the plugin executes.

---

### Why use PreOperation?

PreOperation allows business logic to modify data before the record is committed to the database.

---

### What is Plugin Registration Tool (PRT)?

Plugin Registration Tool is a Microsoft utility used to register plugin assemblies and configure execution steps in Dynamics 365.

---

# Summary

Plugin Registration is an essential part of Microsoft Dynamics 365 development. After building and signing a Class Library project, the generated DLL is deployed using the Plugin Registration Tool. Once the assembly and execution step are registered, Dynamics 365 automatically executes the plugin based on the configured event pipeline.
