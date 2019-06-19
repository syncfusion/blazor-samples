// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.ejsIntrop = {
    invokeEJS: function (id, options, events, nameSpace, dotnet) {
        options = JSON.parse(options, ejsIntrop.parseRevive);
        var type = ejs.base.getValue(nameSpace, window);
        window.ejsIntrop.bindEvents(options, events, dotnet);
        var comp = new type(options);
        comp.appendTo('#' + id);
    },

    setModel: function (id, options, events, nameSpace, dotnet) {
        options = JSON.parse(options, ejsIntrop.parseRevive);
        var type = ejs.base.getValue(nameSpace, window);
        window.ejsIntrop.bindEvents(options, events, dotnet);
        var comp = document.getElementById(id).ej2_instances[0];
        comp.setProperties(options);
        comp.dataBind();
    },
    call: function (id, methodName, arg, nameSpace, dotnet) {
        var comp = document.getElementById(id).ej2_instances[0];
        comp[methodName].apply(comp, arg);
    },
    parseRevive: function (key, value) {
        if (typeof value === "string") {
            return ejsIntrop.escapeChar(value);
        }
        return value;
    },
    escapeChar: function (str) {
        return str.replace(/\n/g, "\\n").replace(/\r/g, "\\r");
    },
    triggerEJEvents: function (arg) {
        if (arg) {
            this.dotnet.invokeMethodAsync("Trigger", this.eventName, window.ejsIntrop.cleanStringify(arg));
        } else {
            this.dotnet.invokeMethodAsync("Trigger", this.eventName, '');
        }
    },
    cleanStringify: function (object) {
        if (object && typeof object === 'object') {
            object = copyWithoutCircularReferences([object], object);
        }
        return JSON.stringify(object);

        function copyWithoutCircularReferences(references, object) {
            var cleanObject = {};
            Object.keys(object).forEach(function (key) {
                var value = object[key];
                if (value && typeof value === 'object') {
                    if (references.indexOf(value) < 0) {
                        references.push(value);
                        cleanObject[key] = copyWithoutCircularReferences(references, value);
                        references.pop();
                    } else {
                        cleanObject[key] = '###_Circular_###';
                    }
                } else if (typeof value !== 'function') {
                    cleanObject[key] = value;
                }
            });
            return cleanObject;
        }
    },
    bindEvents: function (modelObj, events, dotnet) {
        if (events) {
            for (var i = 0; i < events.length; i = i + 1) {
                var curEvent = events[i];
                var scope = { dotnet: dotnet, eventName: curEvent };
                modelObj[curEvent] = window.ejsIntrop.triggerEJEvents.bind(scope);
            }
        }
    }
};