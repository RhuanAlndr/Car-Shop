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
  "name": "name of the brand"
}
```

<h3 id="post-brand-detail">POST /brand</h3>

**REQUEST**
```json
{
  "name": "name-your-brand"
}
```

**RESPONSE**
```json
{
  "id": "id",
  "name": "name-your-brand"
}
```
<h3 id="post-brand-details">POST /brand/{id}</h3>

**REQUEST**
```json
{
  "id": "id",
  "name": "name-your-brand"
}
```

**RESPONSE**
```json
{
  "name": "name of the brand"
}
```

<h3 id="delete-brand-detail">DELETE /brand/{id}</h3>

**REQUEST**
```json
{
  "id": "id",
  "name": "name-your-brand"
}
```

<h2 id="colab">🤝 Collaborators</h2>

Special thank you for all people that contributed for this project.

<table>
  <tr>
    <td align="center">
      <a href="#">
        <img src="https://avatars.githubusercontent.com/u/61896274?v=4" width="100px;" alt="Fernanda Kipper Profile Picture"/><br>
        <sub>
          <b>Fernanda Kipper</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="#">
        <img src="https://t.ctcdn.com.br/n7eZ74KAcU3iYwnQ89-ul9txVxc=/400x400/smart/filters:format(webp)/i490769.jpeg" width="100px;" alt="Elon Musk Picture"/><br>
        <sub>
          <b>Elon Musk</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="#">
        <img src="https://miro.medium.com/max/360/0*1SkS3mSorArvY9kS.jpg" width="100px;" alt="Foto do Steve Jobs"/><br>
        <sub>
          <b>Steve Jobs</b>
        </sub>
      </a>
    </td>
  </tr>
</table>

<h2 id="contribute">📫 Contribute</h2>

Here you will explain how other developers can contribute to your project. For example, explaining how can create their branches, which patterns to follow and how to open an pull request

1. `git clone https://github.com/Fernanda-Kipper/text-editor.git`
2. `git checkout -b feature/NAME`
3. Follow commit patterns
4. Open a Pull Request explaining the problem solved or feature made, if exists, append screenshot of visual modifications and wait for the review!

<h3>Documentations that might help</h3>

[📝 How to create a Pull Request](https://www.atlassian.com/br/git/tutorials/making-a-pull-request)

[💾 Commit pattern](https://gist.github.com/joshbuchea/6f47e86d2510bce28f8e7f42ae84c716)
