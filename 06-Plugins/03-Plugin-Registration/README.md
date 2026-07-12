# Plugin Registration

## Overview

Plugin Registration is the process of deploying a compiled Plugin Assembly (DLL) into Microsoft Dynamics 365 so that custom business logic executes automatically when specific events occur, such as **Create**, **Update**, **Delete**, or other supported messages.

Microsoft Dynamics 365 uses the **Plugin Registration Tool (PRT)** to register assemblies and configure when plugins should execute within the event execution pipeline.

---

# Learning Objectives

After completing this module, you will be able to:

- Understand Plugin Registration in Dynamics 365
- Register Plugin Assemblies
- Register Plugin Steps
- Configure Plugin Execution Pipeline
- Deploy Plugins to Dynamics 365
- Test Plugin Execution

---

# Prerequisites

Before registering a plugin, ensure the following requirements are completed:

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

# Assembly Signing

Before registering a plugin, the assembly must be signed using a **Strong Name Key (.snk)**.

### Navigation

```text
Project
    ↓
Properties
    ↓
Signing
    ↓
Sign the Assembly
    ↓
<Create New Strong Name Key>
```

### Notes

- Provide a meaningful key name.
- Do not enable password protection.
- If Visual Studio shows **"The operation could not be completed"**, restart Visual Studio as **Administrator** and try again.

---

# Build the Project

After signing the project, build the solution.

```text
Build
    ↓
Build Solution
```

A successful build generates a DLL file.

Example:

```text
bin
└── Debug
    └── ASK1026Plugin.dll
```

---

# Register Plugin Assembly

Open the **Plugin Registration Tool** and connect to your Dynamics 365 environment.

Navigate to:

```text
Register
    ↓
Register New Assembly
```

Browse to the generated DLL.

Example:

```text
ASK1026Plugin.dll
```

Select the detected plugin classes and click:

```text
Register Selected Plugins
```

---

# Register Plugin Step

After registering the assembly, register a new execution step.

Typical configuration:

| Property | Value |
|----------|-------|
| Message | Create |
| Primary Entity | sud_sudpluginpractice |
| Secondary Entity | None |
| Stage | PreOperation |
| Execution Mode | Synchronous |
| Deployment | Server |
| Execution Order | 1 |

Click **Register New Step**.

---

# Plugin Execution Pipeline

```text
User Creates Record
        │
        ▼
CRM Executes Plugin Step
        │
        ▼
Plugin Business Logic Runs
        │
        ▼
Record Saved to Database
```

---

# Execution Pipeline Stages

| Stage | Description |
|--------|-------------|
| PreValidation | Executes before CRM validation |
| PreOperation | Executes before the record is committed to the database |
| PostOperation | Executes after the record is successfully saved |

For this project, the plugin is registered in the **PreOperation** stage.

---

# Testing the Plugin

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

If the plugin is registered correctly, the Full Name field is populated automatically during record creation.

---

# Common Issues

## Plugin Does Not Execute

Possible causes:

- Assembly not registered
- Step not registered
- Incorrect Primary Entity
- Wrong Message selected
- Incorrect Pipeline Stage
- Assembly build failed

---

## DLL Not Generated

Possible causes:

- Build failed
- Compilation errors
- Assembly not signed

---

## Strong Name Key Error

Error:

```text
The operation could not be completed.
```

Solution:

- Close Visual Studio.
- Run Visual Studio as **Administrator**.
- Create the Strong Name Key again.

---

## Full Name Field Validation Error

If the **Full Name** field is configured as **Business Required**, Dynamics 365 validates the field before the plugin executes.

Since the plugin populates this field during execution, change the field requirement to **Optional** before testing.

---

# Best Practices

- Always sign plugin assemblies before deployment.
- Build the solution before registering the DLL.
- Register only the required plugin steps.
- Use meaningful assembly and class names.
- Test every deployment after registration.
- Enable tracing for easier debugging.
- Maintain source code using version control.

---

# Interview Questions

### What is Plugin Registration?

Plugin Registration is the process of deploying a compiled plugin assembly (DLL) into Dynamics 365 and configuring when it should execute.

---

### Why is Assembly Signing required?

Dynamics 365 only accepts strongly signed assemblies for plugin deployment.

---

### What is the difference between an Assembly and a Plugin Step?

**Assembly**

- Contains the compiled plugin code (DLL).

**Plugin Step**

- Defines when, where, and how the plugin executes.

---

### What is Plugin Registration Tool (PRT)?

Plugin Registration Tool is a Microsoft utility used to register plugin assemblies and configure execution steps within Dynamics 365.

---

### Why is PreOperation commonly used?

PreOperation allows developers to modify data before it is committed to the database, ensuring business rules are applied before the record is saved.

---

### What happens if a Plugin Step is not registered?

The plugin assembly exists in Dynamics 365, but the business logic never executes because no event triggers it.

---

# Summary

Plugin Registration is an essential deployment step in Microsoft Dynamics 365 development. After creating, signing, and building a Class Library project, the generated DLL is registered using the Plugin Registration Tool. A Plugin Step is then configured to define when the plugin should execute within the Dynamics 365 event pipeline.
