pipeline { 
        agent {label 'windows'}  


    options {
        skipStagesAfterUnstable()
    }
    stages {
        stage('Build & Test') { 
            stage('Build') {
                steps{
                    sh 'msbuild .' 
                }
            }            
    }
}