pipeline { 
        agent {label 'windows'}  


    options {
        skipStagesAfterUnstable()
    }
    stages {
        stage('Build') {
            steps{
                bat 'nuget restore'
                bat 'msbuild .' 
            }
        }            
    }
}