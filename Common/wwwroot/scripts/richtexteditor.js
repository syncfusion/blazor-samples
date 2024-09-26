window.customJsFunctions = {
    importContentFromWord: function () {
        window.sfBlazor.instances["rteCustomWordUpload"].element.click();
    },
    exportContentToPDF: function (rteHtmlData) {
        const hostUrl = 'https://blazor.syncfusion.com/services/production/';
        const html = `<html><head></head><body>${rteHtmlData}</body></html>`;
        fetch(hostUrl + 'api/RichTextEditor/ExportToPdf', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({ html: html }) // Wrap HTML in a JSON object
        }).then(response => {
                if (!response.ok) {
                    throw new Error(`HTTP error! Status: ${response.status}`);
                }
                return response.blob();
            }).then(blob => {
                const url = window.URL.createObjectURL(blob);       // Create a Blob URL from the response and initiate the download
                const a = document.createElement('a');   // Create an anchor element
                a.href = url;
                a.download = 'Sample.pdf';
                document.body.appendChild(a);             // Append the anchor element to the document
                a.click();                                // Trigger a click on the anchor element to initiate the download
                document.body.removeChild(a);             // Remove the anchor element from the document
                window.URL.revokeObjectURL(url);          // Revoke the object URL to free up resources
            })
            .catch(error => {
                console.error('Fetch error:', error);
            });
    },
    exportContentToWord: function (rteHtmlData) {
        const hostUrl = 'https://blazor.syncfusion.com/services/production/';
        const html = `<html><head></head><body>${rteHtmlData}</body></html>`;
        fetch(hostUrl + 'api/RichTextEditor/ExportToDocx', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({ html: html }) // Wrap HTML in a JSON object
        })
        .then(response => {
            if (!response.ok) {
                throw new Error(`HTTP error! Status: ${response.status}`);
            }
            const filename = 'Result.docx';
            // Create a Blob from the response and initiate the download
            return response.blob().then(blob => ({ blob, filename }));
        })
        .then(({ blob, filename }) => {
            const url = window.URL.createObjectURL(blob);       // Create a Blob URL from the response and initiate the download    
            const a = document.createElement('a');              // Create an anchor element
            a.href = url;
            a.download = filename;
            document.body.appendChild(a);                       // Append the anchor element to the document
            a.click();                                          // Trigger a click on the anchor element to initiate the download
            document.body.removeChild(a);                       // Remove the anchor element from the document
            window.URL.revokeObjectURL(url);                    // Revoke the object URL to free up resources
        })
        .catch(error => {
            console.error('Fetch error:', error);
        });
    }
};
