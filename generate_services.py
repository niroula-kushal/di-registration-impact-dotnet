import os
import random

# Service domains and their counts
domains = {
    "Authentication": 50,
    "Authorization": 50,
    "Business": 150,
    "Data": 100,
    "External": 80,
    "Infrastructure": 100,
    "Notification": 60,
    "Payment": 70,
    "Reporting": 80,
    "Security": 70,
    "Validation": 60,
    "Workflow": 50,
    "Analytics": 60,
    "Integration": 50,
    "Cache": 40,
    "Logging": 30,
    "Monitoring": 40,
}

# Method name templates
method_templates = [
    "Process{Name}",
    "Get{Name}",
    "Create{Name}",
    "Update{Name}",
    "Delete{Name}",
    "Validate{Name}",
    "Transform{Name}",
    "Calculate{Name}",
    "Generate{Name}",
    "Execute{Name}",
    "Handle{Name}",
    "Retrieve{Name}",
    "Store{Name}",
    "Send{Name}",
    "Receive{Name}",
    "Parse{Name}",
    "Format{Name}",
    "Filter{Name}",
    "Sort{Name}",
    "Search{Name}",
]

# Service name templates
service_templates = {
    "Authentication": ["Token", "Session", "Credential", "Login", "Logout", "UserAuth", "ApiKey", "OAuth", "Jwt", "Refresh"],
    "Authorization": ["Permission", "Role", "Access", "Policy", "Rule", "Guard", "Check", "Verify", "Enforce", "Grant"],
    "Business": ["Order", "Product", "Customer", "Invoice", "Transaction", "Account", "Contract", "Agreement", "Quote", "Proposal"],
    "Data": ["Repository", "Query", "Command", "Migration", "Backup", "Restore", "Sync", "Import", "Export", "Transform"],
    "External": ["Api", "Client", "Gateway", "Adapter", "Connector", "Bridge", "Proxy", "Interface", "Handler", "Wrapper"],
    "Infrastructure": ["Config", "Setting", "Resource", "Pool", "Manager", "Factory", "Builder", "Provider", "Registry", "Locator"],
    "Notification": ["Email", "Sms", "Push", "Alert", "Message", "Broadcast", "Channel", "Template", "Queue", "Delivery"],
    "Payment": ["Processor", "Gateway", "Transaction", "Refund", "Subscription", "Billing", "Invoice", "Receipt", "Method", "Verification"],
    "Reporting": ["Generator", "Exporter", "Formatter", "Scheduler", "Template", "Builder", "Renderer", "Aggregator", "Analyzer", "Dashboard"],
    "Security": ["Encryption", "Decryption", "Hash", "Token", "Certificate", "Key", "Vault", "Audit", "Compliance", "Scan"],
    "Validation": ["Rule", "Checker", "Verifier", "Validator", "Sanitizer", "Normalizer", "Parser", "Formatter", "Enforcer", "Guard"],
    "Workflow": ["Engine", "Orchestrator", "Step", "Task", "Process", "Pipeline", "Handler", "Router", "Scheduler", "Executor"],
    "Analytics": ["Collector", "Processor", "Aggregator", "Analyzer", "Tracker", "Metric", "Event", "Log", "Stream", "Query"],
    "Integration": ["Adapter", "Connector", "Bridge", "Mapper", "Transformer", "Converter", "Translator", "Mediator", "Broker", "Hub"],
    "Cache": ["Manager", "Provider", "Store", "Invalidator", "Refresher", "Loader", "Writer", "Reader", "Distributed", "Local"],
    "Logging": ["Writer", "Formatter", "Filter", "Appender", "Handler", "Collector", "Processor", "Aggregator", "Sink", "Target"],
    "Monitoring": ["Collector", "Aggregator", "Alert", "Metric", "Health", "Performance", "Trace", "Profiler", "Watcher", "Observer"],
}

def generate_service_name(domain, index, used_names):
    """Generate a unique service name"""
    templates = service_templates.get(domain, ["Service"])
    base = random.choice(templates)
    
    # Always include index to ensure uniqueness
    if index == 0:
        candidate = f"{base}Service"
    else:
        candidate = f"{base}{index:03d}Service"
    
    # If still duplicate, add domain prefix
    if candidate in used_names:
        candidate = f"{domain}{base}{index:03d}Service"
    
    used_names.add(candidate)
    return candidate

def generate_method_name(service_name):
    base = service_name.replace("Service", "")
    template = random.choice(method_templates)
    return template.replace("{Name}", base)

def generate_dependency(domain, service_index, all_services_by_name, all_services_list):
    """Generate a dependency that actually exists"""
    if not all_services_list:
        return None
    
    # Prefer dependencies from same domain, but allow cross-domain
    same_domain = [s for s in all_services_list if s[1] == domain and s[2] != service_index]
    other_domain = [s for s in all_services_list if s[1] != domain]
    
    candidates = same_domain if same_domain else other_domain[:20]  # Limit cross-domain
    
    if not candidates:
        return None
    
    dep_domain, dep_index, dep_name = random.choice(candidates)
    return dep_name

def generate_service(domain, service_index, all_services_by_name, all_services_list):
    service_name = generate_service_name(domain, service_index, all_services_by_name)
    namespace = f"stream_response_ef_core.Services.{domain}"
    
    # Generate 2-4 dependencies from existing services
    num_deps = random.randint(2, 4)
    dependencies = []
    for _ in range(num_deps):
        dep = generate_dependency(domain, service_index, all_services_by_name, all_services_list)
        if dep and dep not in dependencies:
            dependencies.append(dep)
    
    # Generate 2-3 methods with consistent signatures
    num_methods = random.randint(2, 3)
    methods = []
    for i in range(num_methods):
        method_name = generate_method_name(service_name)
        if i == 0:
            method_name = f"Process{service_name.replace('Service', '')}"
        methods.append(method_name)
    
    # Generate method signatures (store to reuse in interface and implementation)
    method_signatures = []
    for method in methods:
        # Prefer Task-based return types for better async support
        return_type = random.choice(["Task<string>", "Task<int>", "Task<bool>", "string", "int", "bool", "void"])
        param_type = random.choice(["string", "int", "Guid", "object"])
        param_name = random.choice(["id", "data", "request", "input", "value"])
        method_signatures.append((method, return_type, param_type, param_name))
    
    dep_fields = ""
    dep_constructor_params = ""
    dep_assignments = ""
    
    for dep in dependencies:
        dep_interface = f"I{dep}"
        dep_var = dep[0].lower() + dep[1:]
        dep_fields += f"    private readonly {dep_interface} _{dep_var};\n"
        dep_constructor_params += f", {dep_interface} {dep_var}"
        dep_assignments += f"        _{dep_var} = {dep_var} ?? throw new ArgumentNullException(nameof({dep_var}));\n"
    
    method_code = ""
    for method, return_type, param_type, param_name in method_signatures:
        is_async = return_type.startswith("Task")
        async_keyword = "async " if is_async else ""
        
        method_code += f"""
    public {async_keyword}{return_type} {method}({param_type} {param_name})
    {{
        // Implementation for {method}
        _logger.LogInformation("Executing {{MethodName}} with {{ParamName}}: {{ParamValue}}", nameof({method}), nameof({param_name}), {param_name});
        
"""
        
        # Add dependency calls - only if we have dependencies and the method supports it
        if dependencies:
            dep = random.choice(dependencies)
            dep_var = dep[0].lower() + dep[1:]
            dep_base = dep.replace('Service', '')
            
            # Only call async methods if our method is async, and use proper parameter conversion
            if is_async:
                # Always convert to string to avoid type mismatches
                if param_type == "string":
                    param_value = param_name
                else:
                    param_value = f"{param_name}.ToString()"
                # Use Task.FromResult to handle both async and sync dependency methods
                method_code += f"        _ = _{dep_var}; // Using dependency\n"
                method_code += f"        await Task.CompletedTask; // Simulate async operation\n"
            else:
                # For non-async, just reference the dependency
                method_code += f"        _ = _{dep_var}; // Using dependency\n"
        
        # Return statements
        if return_type.startswith("Task"):
            if return_type == "Task<string>":
                method_code += f"        return $\"Result from {method}\";\n"
            elif return_type == "Task<int>":
                method_code += "        return 42;\n"
            elif return_type == "Task<bool>":
                method_code += "        return true;\n"
            else:
                method_code += "        return;\n"
        elif return_type == "string":
            method_code += f"        return $\"Result from {method}\";\n"
        elif return_type == "int":
            method_code += "        return 42;\n"
        elif return_type == "bool":
            method_code += "        return true;\n"
        # void methods don't need return
        
        method_code += "    }\n"
    
    code = f"""using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace {namespace};

public interface I{service_name}
{{
"""
    for method, return_type, param_type, param_name in method_signatures:
        code += f"    {return_type} {method}({param_type} {param_name});\n"
    
    code += f"""}}

public class {service_name} : I{service_name}
{{
    private readonly ILogger<{service_name}> _logger;
{dep_fields}
    public {service_name}(ILogger<{service_name}> logger{dep_constructor_params})
    {{
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
{dep_assignments}    }}
{method_code}
}}
"""
    
    return service_name, namespace, code, dependencies

def main():
    base_dir = "Services"
    os.makedirs(base_dir, exist_ok=True)
    
    all_services_by_name = set()  # Track all service names to avoid duplicates
    all_services_list = []  # List of (domain, index, service_name) tuples for dependency generation
    service_registrations = []
    
    total_services = 0
    
    # First pass: generate all service names
    service_plan = []
    for domain, count in domains.items():
        for i in range(count):
            templates = service_templates.get(domain, ["Service"])
            base = random.choice(templates)
            if i == 0:
                candidate = f"{base}Service"
            else:
                candidate = f"{base}{i:03d}Service"
            
            # Ensure uniqueness
            if candidate in all_services_by_name:
                candidate = f"{domain}{base}{i:03d}Service"
            
            all_services_by_name.add(candidate)
            service_plan.append((domain, i, candidate))
    
    # Second pass: generate services with dependencies
    for domain, service_index, service_name in service_plan:
        namespace = f"stream_response_ef_core.Services.{domain}"
        
        # Generate dependencies from already-created services
        num_deps = random.randint(2, 4)
        dependencies = []
        existing_services = [(d, idx, name) for d, idx, name in all_services_list 
                           if not (d == domain and idx == service_index)]
        
        for _ in range(num_deps):
            if existing_services:
                dep_domain, dep_idx, dep_name = random.choice(existing_services)
                if dep_name not in dependencies:
                    dependencies.append(dep_name)
        
        # Generate method signatures - ensure uniqueness
        num_methods = random.randint(2, 3)
        methods = []
        used_signatures = set()
        
        for i in range(num_methods):
            method_name = generate_method_name(service_name)
            if i == 0:
                method_name = f"Process{service_name.replace('Service', '')}"
            
            # Ensure unique method signature
            max_attempts = 20
            for attempt in range(max_attempts):
                return_type = random.choice(["Task<string>", "Task<int>", "Task<bool>", "string", "int", "bool", "void"])
                param_type = random.choice(["string", "int", "Guid", "object"])
                param_name = random.choice(["id", "data", "request", "input", "value"])
                signature = (method_name, param_type)
                
                if signature not in used_signatures:
                    used_signatures.add(signature)
                    methods.append((method_name, return_type, param_type, param_name))
                    break
                elif attempt < max_attempts - 1:
                    # Try a different method name if signature already used
                    method_name = generate_method_name(service_name)
            else:
                # If we couldn't find a unique signature, use a numbered version
                method_name = f"{method_name}{i}"
                return_type = random.choice(["Task<string>", "Task<int>", "Task<bool>", "string", "int", "bool", "void"])
                param_type = random.choice(["string", "int", "Guid", "object"])
                param_name = random.choice(["id", "data", "request", "input", "value"])
                methods.append((method_name, return_type, param_type, param_name))
        
        method_signatures = methods
        
        dep_fields = ""
        dep_constructor_params = ""
        dep_assignments = ""
        dep_namespaces = set()
        
        for dep in dependencies:
            # Find the namespace of the dependency
            dep_namespace = None
            for d, idx, name in all_services_list:
                if name == dep:
                    dep_namespace = f"stream_response_ef_core.Services.{d}"
                    break
            
            if dep_namespace and dep_namespace != namespace:
                dep_namespaces.add(dep_namespace)
            
            dep_interface = f"I{dep}"
            dep_var = dep[0].lower() + dep[1:]
            dep_fields += f"    private readonly {dep_interface} _{dep_var};\n"
            dep_constructor_params += f", {dep_interface} {dep_var}"
            dep_assignments += f"        _{dep_var} = {dep_var} ?? throw new ArgumentNullException(nameof({dep_var}));\n"
        
        # Build using statements
        using_statements = "using Microsoft.Extensions.Logging;\nusing System;\nusing System.Threading.Tasks;\n"
        for dep_ns in sorted(dep_namespaces):
            using_statements += f"using {dep_ns};\n"
        
        method_code = ""
        for method, return_type, param_type, param_name in method_signatures:
            is_async = return_type.startswith("Task")
            async_keyword = "async " if is_async else ""
            
            method_code += f"""
    public {async_keyword}{return_type} {method}({param_type} {param_name})
    {{
        // Implementation for {method}
        _logger.LogInformation("Executing {{MethodName}} with {{ParamName}}: {{ParamValue}}", nameof({method}), nameof({param_name}), {param_name});
        
"""
            
            if dependencies:
                dep = random.choice(dependencies)
                dep_var = dep[0].lower() + dep[1:]
                if is_async:
                    method_code += f"        _ = _{dep_var}; // Using dependency\n"
                    method_code += f"        await Task.CompletedTask; // Simulate async operation\n"
                else:
                    method_code += f"        _ = _{dep_var}; // Using dependency\n"
            
            if return_type.startswith("Task"):
                if return_type == "Task<string>":
                    method_code += f"        return $\"Result from {method}\";\n"
                elif return_type == "Task<int>":
                    method_code += "        return 42;\n"
                elif return_type == "Task<bool>":
                    method_code += "        return true;\n"
                else:
                    method_code += "        return;\n"
            elif return_type == "string":
                method_code += f"        return $\"Result from {method}\";\n"
            elif return_type == "int":
                method_code += "        return 42;\n"
            elif return_type == "bool":
                method_code += "        return true;\n"
            
            method_code += "    }\n"
        
        code = f"""{using_statements}
namespace {namespace};

public interface I{service_name}
{{
"""
        for method, return_type, param_type, param_name in method_signatures:
            code += f"    {return_type} {method}({param_type} {param_name});\n"
        
        code += f"""}}

public class {service_name} : I{service_name}
{{
    private readonly ILogger<{service_name}> _logger;
{dep_fields}
    public {service_name}(ILogger<{service_name}> logger{dep_constructor_params})
    {{
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
{dep_assignments}    }}
{method_code}
}}
"""
        
        domain_dir = os.path.join(base_dir, domain)
        os.makedirs(domain_dir, exist_ok=True)
        file_path = os.path.join(domain_dir, f"{service_name}.cs")
        
        with open(file_path, 'w', encoding='utf-8') as f:
            f.write(code)
        
        all_services_list.append((domain, service_index, service_name))
        service_registrations.append((namespace, service_name))
        total_services += 1
        
        if total_services % 100 == 0:
            print(f"Generated {total_services} services...")
    
    # Generate registration code
    reg_code = "// Auto-generated service registrations\n"
    reg_code += "// Add this to Program.cs in the service registration section\n\n"
    
    for namespace, service_name in service_registrations:
        interface_name = f"I{service_name}"
        reg_code += f"builder.Services.Register<{namespace}.{interface_name}, {namespace}.{service_name}>();\n"
    
    with open("ServiceRegistrations.cs", 'w', encoding='utf-8') as f:
        f.write(reg_code)
    
    print(f"\nGenerated {total_services} services in {len(domains)} domains")
    print("Service registration code saved to ServiceRegistrations.cs")

if __name__ == "__main__":
    main()