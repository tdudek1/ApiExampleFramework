pipeline { 
        agent windows  


    options {
        skipStagesAfterUnstable()
    }
    stages {
        stage('Build & Test') { 
            stages {
                stage('Build') {
                    steps{
                        sh 'msbuild .' 
                    }
                }
        }
    }
}