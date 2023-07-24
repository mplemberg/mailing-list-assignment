const apiClient = {
    async addContact(contact) {
        return await fetch('api/contacts', {
            method: "POST",
            headers: {
                'Content-Type': 'application/json;charset=utf-8'
            },
            body: JSON.stringify(contact)
        });
    }
}

export default apiClient;