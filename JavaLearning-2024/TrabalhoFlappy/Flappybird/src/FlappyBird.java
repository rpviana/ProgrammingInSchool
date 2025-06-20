import java.awt.*;
import java.awt.event.*;
import java.util.ArrayList;
import java.util.Random;
import javax.swing.*;
import javax.sound.sampled.*;
import java.io.*;

public class FlappyBird extends JPanel implements ActionListener, KeyListener {
    int boardWidth = 360; // Largura do painel do jogo
    int boardHeight = 640; // Altura do painel do jogo

    /// Variáveis para armazenar as imagens
    Image backgroundImg; // Imagem do plano de fundo
    Image birdImg; // Imagem do pássaro
    Image topPipeImg; // Imagem do tubo superior
    Image bottomPipeImg; // Imagem do tubo inferior
    Image playButtonImg; // Imagem do botão de jogar

    // Variáveis para armazenar as posições e dimensões do pássaro
    int birdX = boardWidth/8; // Posição inicial do pássaro no eixo X
    int birdY = boardWidth/2; // Posição inicial do pássaro no eixo Y
    int birdWidth = 34; // Largura do pássaro
    int birdHeight = 24; // Altura do pássaro

     // Classe para representar o pássaro
     class Bird {
        int x = birdX; // Posição do pássaro no eixo X
        int y = birdY; // Posição do pássaro no eixo Y
        int width = birdWidth; // Largura do pássaro
        int height = birdHeight; // Altura do pássaro
        Image img; // Imagem do pássaro

        Bird(Image img) {
            this.img = img;
        }
    }

    // Variáveis para armazenar as posições e dimensões dos tubos
    int pipeX = boardWidth; // Posição inicial dos tubos no eixo X
    int pipeY = 0; // Posição inicial dos tubos no eixo Y
    int pipeWidth = 64; // Largura dos tubos
    int pipeHeight = 512; // Altura dos tubos
    
    // Classe para representar os tubos
    class Pipe {
        int x = pipeX; // Posição dos tubos no eixo X
        int y = pipeY; // Posição dos tubos no eixo Y
        int width = pipeWidth; // Largura dos tubos
        int height = pipeHeight; // Altura dos tubos
        Image img; // Imagem dos tubos
        boolean passed = false; // Variável para verificar se o pássaro já passou pelos tubos

        Pipe(Image img) {
            this.img = img;
        }
    }

    // Lógica do jogo
    Bird bird; // Objeto do tipo Bird que representa o pássaro
    int velocityX = -4; // Velocidade horizontal do pássaro
    int velocityY = 0; // Velocidade vertical do pássaro
    int gravity = 1; // Gravidade que afeta o pássaro

    ArrayList<Pipe> pipes; // Lista de objetos do tipo Pipe que representam os tubos
    Random random = new Random(); // Objeto para gerar números aleatórios

    Timer gameLoop; // Timer para atualizar o jogo
    Timer placePipeTimer; // Timer para colocar os tubos em cena
    boolean gameOver = false; // Variável para verificar se o jogo terminou
    boolean gameStarted = false; // Variável para verificar se o jogo começou
    boolean countdownStarted = false; // Variável para verificar se a contagem regressiva começou
    int countdown = 3; // Contagem regressiva antes do início do jogo
    Timer countdownTimer; // Timer para a contagem regressiva

    Rectangle playButton; // Retângulo que representa o botão de jogar

    double score = 0; // Pontuação do jogador

    Clip musicClip; // Variável para armazenar o clip de áudio
    int loopStartPoint = 0; // Ponto de início do loop (em frames)
    int loopEndPoint = 20 * 44100; // Ponto de fim do loop (20 segundos * taxa de amostragem de 44100 Hz)

    FlappyBird() {
        setPreferredSize(new Dimension(boardWidth, boardHeight));
        setFocusable(true);
        addKeyListener(this);
        addMouseListener(new MouseAdapter() {
            public void mousePressed(MouseEvent e) {
                if (playButton != null && playButton.contains(e.getPoint())) {
                    startGame(); // Inicia o jogo quando o botão de jogar é clicado
                }
            }
        });

        // Carrega as imagens
        backgroundImg = new ImageIcon(getClass().getResource("./flappybirdbg.png")).getImage();
        birdImg = new ImageIcon(getClass().getResource("./flappybird.png")).getImage();
        topPipeImg = new ImageIcon(getClass().getResource("./toppipe.png")).getImage();
        bottomPipeImg = new ImageIcon(getClass().getResource("./bottompipe.png")).getImage();
        playButtonImg = new ImageIcon(getClass().getResource("./playbutton.png")).getImage();

        // Cria o pássaro
        bird = new Bird(birdImg);
        pipes = new ArrayList<Pipe>();

        // Inicia o timer para colocação dos tubos
        placePipeTimer = new Timer(1500, new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                placePipes(); // Método para posicionar os tubos na tela
            }
        });
        placePipeTimer.start();
        
		// Inicia o timer do jogo
		gameLoop = new Timer(1000/60, this); // naosei
        gameLoop.start();

        // Carrega e configura a música
        try {
            File musicFile = new File("music_pou.wav");
            AudioInputStream audioInputStream = AudioSystem.getAudioInputStream(musicFile);
            musicClip = AudioSystem.getClip();
            musicClip.open(audioInputStream);

            // Define os pontos de loop na música
            musicClip.setLoopPoints(loopStartPoint, loopEndPoint);
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }
    
    void placePipes() {
        int randomPipeY = (int) (pipeY - pipeHeight/4 - Math.random()*(pipeHeight/2));
        int openingSpace = boardHeight/4;
    
        Pipe topPipe = new Pipe(topPipeImg);
        topPipe.y = randomPipeY;
        pipes.add(topPipe);
    
        Pipe bottomPipe = new Pipe(bottomPipeImg);
        bottomPipe.y = topPipe.y  + pipeHeight + openingSpace;
        pipes.add(bottomPipe);
    }
    
    
    public void paintComponent(Graphics g) {
		super.paintComponent(g);
		draw(g);
	}

	public void draw(Graphics g) {
        // Desenha o plano de fundo
        g.drawImage(backgroundImg, 0, 0, this.boardWidth, this.boardHeight, null);

        if (!gameStarted) {
            // Desenha o botão de jogar
            int playButtonWidth = 100;
            int playButtonHeight = 50;
            int playButtonX = (boardWidth - playButtonWidth) / 2;
            int playButtonY = (boardHeight - playButtonHeight) / 2;

            playButton = new Rectangle(playButtonX, playButtonY, playButtonWidth, playButtonHeight);

            g.drawImage(playButtonImg, playButtonX, playButtonY, playButtonWidth, playButtonHeight, null);
        } else {
            // Desenha o pássaro
            g.drawImage(birdImg, bird.x, bird.y, bird.width, bird.height, null);

            // Desenha os tubos
            for (int i = 0; i < pipes.size(); i++) {
                Pipe pipe = pipes.get(i);
                g.drawImage(pipe.img, pipe.x, pipe.y, pipe.width, pipe.height, null);
            }

            // Desenha a pontuação
            g.setColor(Color.white);
            g.setFont(new Font("Arial", Font.PLAIN, 32));
            if (gameOver) {
                g.drawString("Game Over: " + String.valueOf((int) score), 10, 35);
                if (score < 15) {
                    g.drawString("Score horrível", 10, 70);
                } else if (score < 25) {
                    g.drawString("Score quase horrível", 10, 70);
                } else if (score < 50) {
                    g.drawString("Ja vi pior", 10, 70);
                } else {
                    g.drawString("maquina!", 10, 70);
                }
            } else {
                g.drawString(String.valueOf((int) score), 10, 35);
            }
        }

        if (countdownStarted) {
            g.setFont(new Font("Arial", Font.BOLD, 48));
            g.setColor(Color.white);
            g.drawString(String.valueOf(countdown), boardWidth / 2 - 10, boardHeight / 2);
        }
	}

    public void move() {
        velocityY += gravity;
        bird.y += velocityY;
        bird.y = Math.max(bird.y, 0);

        for (int i = 0; i < pipes.size(); i++) {
            Pipe pipe = pipes.get(i);
            pipe.x += velocityX;

            if (!pipe.passed && bird.x > pipe.x + pipe.width) {
                score += 0.5; 
                pipe.passed = true;
            }

            if (collision(bird, pipe)) {
                gameOver = true;
            }
        }

        if (bird.y > boardHeight) {
            gameOver = true;
        }
    }

    boolean collision(Bird a, Pipe b) {
        return a.x < b.x + b.width &&   
               a.x + a.width > b.x &&   
               a.y < b.y + b.height &&  
               a.y + a.height > b.y;    
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        move();
        repaint();
        if (gameOver) {
            placePipeTimer.stop();
            gameLoop.stop();
        }

        if (countdownStarted) {
            countdown--;
            if (countdown == 0) {
                countdownStarted = false;
                startGame();
            }
            repaint();
        }
    }  

    @Override
    public void keyPressed(KeyEvent e) {
        if (!gameStarted && e.getKeyCode() == KeyEvent.VK_SPACE && !countdownStarted) {
            countdownStarted = true;
            countdownTimer = new Timer(1000, new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {
                    if (countdown > 0) {
                        countdown--;
                        repaint();
                    } else {
                        countdownTimer.stop();
                        countdownStarted = false;
                        startGame();
                    }
                }
            });
            countdownTimer.setInitialDelay(0);
            countdownTimer.start();
            repaint(); 
        } else if (gameStarted && e.getKeyCode() == KeyEvent.VK_SPACE) {
            velocityY = -9;
    
            if (gameOver) {
                bird.y = birdY;
                velocityY = 0;
                pipes.clear();
                gameOver = false;
                score = 0;
                gameLoop.start();
                placePipeTimer.start();
            }
        }
    }

    void startGame() {
        gameStarted = true;
        playMusic(); // Inicia a música quando o jogo começa
        requestFocusInWindow(); 
    }

    void playMusic() {
        try {
            if (!musicClip.isOpen()) {
                musicClip.open();
            }
            musicClip.loop(Clip.LOOP_CONTINUOUSLY);
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }

    void stopMusic() {
        musicClip.stop(); 
    }

    @Override
    public void keyTyped(KeyEvent e) {}

    @Override
    public void keyReleased(KeyEvent e) {}

    public static void main(String[] args) {
        JFrame frame = new JFrame("Flappy Bird");
        FlappyBird flappyBird = new FlappyBird();
        frame.add(flappyBird);
        frame.pack();
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setLocationRelativeTo(null);
        frame.setVisible(true);
    }
}
