```html
<style>
.dev-card {
    background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
    padding: 20px;
    border-radius: 15px;
    color: white;
    font-family: Arial, sans-serif;
    max-width: 400px;
    margin: 20px auto;
    text-align: center;
    box-shadow: 0 10px 30px rgba(0,0,0,0.3);
    transition: transform 0.3s ease;
}
.dev-card:hover {
    transform: translateY(-5px);
}
.skill-bar {
    background: rgba(255,255,255,0.2);
    border-radius: 10px;
    margin: 10px 0;
    overflow: hidden;
}
.skill-level {
    background: #4CAF50;
    height: 10px;
    border-radius: 10px;
    transition: width 1s ease;
}
</style>

<div class="dev-card">
    <h2>🚀 Студент разработки</h2>
    <p>Изучаю Git, Python и веб-технологии</p>
    
    <div class="skill-bar">
        <div class="skill-level" style="width: 85%"></div>
    </div>
    <p>Git: 85%</p>
    
    <div class="skill-bar">
        <div class="skill-level" style="width: 70%"></div>
    </div>
    <p>Python: 70%</p>
    
    <div class="skill-bar">
        <div class="skill-level" style="width: 60%"></div>
    </div>
    <p>JavaScript: 60%</p>
</div>
```