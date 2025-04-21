<h1 align="center" style="font-weight: bold;">Car Shop 🚗</h1>

<p align="center">
 <a href="#tech">Technologies</a> • 
 <a href="#started">Getting Started</a> • 
  <a href="#routes">API Endpoints</a> •
 <a href="#colab">Collaborators</a> •
 <a href="#contribute">Contribute</a>
</p>

<p align="center">
    <b>The Car Shop is a API where you can manage cars. You can create, edit and delete data of the cars.</b>
</p>

<h2 id="technologies">💻 Technologies</h2>

- Asp .Net
- C#
- SQLServer

<h2 id="started">🚀 Getting started</h2>

Here you describe how to run your project locally

<h3>Cloning</h3>

How to clone your project

```bash
git clone https://github.com/RhuanAlndr/Car-Shop
```

<h3>Starting</h3>

How to start your project

```bash
cd project-name
npm some-command-to-run
```

<h2 id="routes">📍 API Endpoints</h2>

Here you can list the main routes of your API, and what are their expected request bodies.
​
| route               | description                                          
|----------------------|-----------------------------------------------------
| <kbd>GET /brand</kbd>     | retrieves all brands [response details](#get-brands-details)
| <kbd>POST /brand</kbd>     | create a new brand [response details](#post-brand-detail)
| <kbd>POST /brand/{id}</kbd>     | edit a brand [response details](#post-brand-details)
| <kbd>DELETE /brand/{id}</kbd>     | delete a brand [response details](#delete-brand-detail)
| <kbd>GET /cars</kbd>     | retrieves all cars [response details](#get-cars-details)
| <kbd>POST /car</kbd>     | create a new car [response details](#post-car-detail)
| <kbd>POST /car/{id}</kbd>     | edit a car [response details](#post-car-detail)
| <kbd>DELETE /car/{id}</kbd>     | delete a car [response details](#delete-car-detail)

<h3 id="get-brands-details">GET /brand</h3>

**RESPONSE**
```json
{
  "name": "string"
}
```

<h3 id="post-brand-detail">POST /brand</h3>

**REQUEST**
```json
{
  "name": "string"
}
```

**RESPONSE**
```json
{
  "id": "int",
  "name": "string"
}
```
<h3 id="post-brand-details">POST /brand/{id}</h3>

**REQUEST**
```json
{
  "id": "int",
  "name": "string"
}
```

**RESPONSE**
```json
{
  "name": "string"
}
```

<h3 id="delete-brand-detail">DELETE /brand/{id}</h3>

**REQUEST**
```json
{
  "id": "int",
  "name": "string"
}
```
<h3 id="get-cars-details">GET /car</h3>

**RESPONSE**
```json
{
  "name": "string",
  "brand_name": "string",
  "year": "yyyy"
}
```

<h3 id="post-car-detail">POST /car</h3>

**REQUEST**
```json
{
  "name": "string",
  "brand_name": "string",
  "year": "yyyy"
}
```

**RESPONSE**
```json
{
  "id": "int",
  "name": "string",
  "year": "yyyy",
  "brand_id": "int",
  "brand_name": "string"
}
```
<h3 id="post-car-details">POST /car/{id}</h3>

**REQUEST**
```json
{
  "id": "int",
  "name": "string",
  "brand_name": "string",
  "year": "yyyy"
}
```

**RESPONSE**
```json
{
  "name": "string",
  "brand_name": "string",
  "year": "yyyy"
}
```

<h3 id="delete-car-detail">DELETE /car/{id}</h3>

**REQUEST**
```json
{
  "id": "int",
  "name": "string",
  "brand_name": "string",
  "year": "yyyy"
}
```

<h2 id="contribute">Contribute 📫</h2>

Please, feel free to contribute to my project by following the steps below:

1. `git clone https://github.com/Fernanda-Kipper/text-editor.git`
2. `git checkout -b feature/NAME`
4. Open a Pull Request explaining the problem solved or feature made, if exists, append screenshot of visual modifications and wait for the review!

<h3>Documentations that might help</h3>

[📝 How to create a Pull Request](https://www.atlassian.com/br/git/tutorials/making-a-pull-request)
